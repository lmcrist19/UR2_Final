using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace UR2_Final_Crist
{
    public partial class Form1 : Form
    {
        VideoCapture capture;

        Thread captureThread;
        Thread serialMonitoringThread;

        private Point paperCenter = new Point();
        private Point basePoint = new Point();

        private Mat frame = new Mat();
        private Mat grayImage = new Mat();
        private Mat blurredImage = new Mat();
        private Mat decoratedImage = new Mat();
        private Mat binaryImage = new Mat();
        private Mat screenshot = new Mat();
        private Mat binaryImageClone = new Mat();

        SerialPort arduinoSerial = new SerialPort();

        List<Shape> shapeList = new List<Shape>();

        private int ksize = 9;
        private int minThresh = 80;
        private int maxThresh = 255;
        private int sqArea = 850;
        private int triArea = 230;
        private int paperArea = 23000;

        private double pxToIn = 0;

        private bool enableCoordinateSending = false;

        private string toSend;
        private string triORsq = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Begin form and create a thread for displaying captured video
            capture = new VideoCapture(1);
            captureThread = new Thread(MainLoop);
            captureThread.Start();
            // Attempt to initialize connection to arduino at specified port
            try
            {
                arduinoSerial.PortName = "COM15";
                arduinoSerial.BaudRate = 9600;
                arduinoSerial.Open();
                // Create a thread to monitor incoming serial data for returned information
                serialMonitoringThread = new Thread(MonitorSerialData);
                serialMonitoringThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Initializing COM port");
                Close();
            }
            
        }
        private void MainLoop()
        {
            while (capture.IsOpened)
            {
                ConfigureWebcam();
                try
                {
                    // Enclosed in a try-catch to avoid exceptions that did not affect the functionality of the program
                    rawPictureBox.Image = frame.ToBitmap();
                    blurPictureBox.Image = grayImage.ToBitmap();
                    binaryPictureBox.Image = binaryImage.ToBitmap();
                }
                catch {  }
                if(enableCoordinateSending)
                {
                    // So long as the Arduino is ready to accept information, data is monitored and sent. Initialized as false until start button is pressed, then waits for Arduino to send enable and disable
                    List<Shape> triangleList = new List<Shape>();
                    List<Shape> squareList = new List<Shape>();

                    screenshot = binaryImageClone; // Take the clone and modify it for display in Form
                    DetectShapes();
                    SquareVSTriangle(triangleList, squareList);
                    ShapeFormatandSend(triangleList, squareList);
                }
                // Dispose of frames to clear data and prevent overflow
                frame.Dispose(); 
                binaryImageClone.Dispose();
            }
        }
        private void ConfigureWebcam()
        {
            // Configure webcam and displays to allow for optimization of view
            frame = capture.QueryFrame();
            int newHeight = (frame.Size.Height * rawPictureBox.Size.Width) / frame.Size.Width;
            Size newSize = new Size(rawPictureBox.Size.Width, newHeight);
            CvInvoke.Resize(frame, frame, newSize); // Fit captured video to frame in Form
            CvInvoke.GaussianBlur(frame, blurredImage, new Size(ksize, ksize), 0); // ksize is initialized in setup and adjusted by the respective trackbar to adjust blur
            CvInvoke.CvtColor(blurredImage, grayImage, typeof(Bgr), typeof(Gray));
            CvInvoke.Threshold(grayImage, binaryImage, minThresh, maxThresh, Emgu.CV.CvEnum.ThresholdType.Binary); // maxThresh and minThresh are initialized in setup and adjusted by the respective trackbar to adjust threshold
            CvInvoke.CvtColor(binaryImage, decoratedImage, typeof(Gray), typeof(Bgr));
            binaryImageClone = binaryImage.Clone(); // Necessary for taking a screenshot in order to limit monitoring of shapes and sending data
        }
        private void DetectShapes()
        {
            using (VectorOfVectorOfPoint shapes = new VectorOfVectorOfPoint())
            {
                // Detect all contours and display amount of shapes in display, including unwanted shapes
                CvInvoke.FindContours(screenshot, shapes, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
                Invoke(new Action(() => { shapeCountLabel.Text = $"{shapes.Size}"; }));
                
                // Parse through every shape/contour detected in the screenshot frame
                for (int i = 0; i < shapes.Size; i++)
                {
                    VectorOfPoint shape = shapes[i];
                    double area = CvInvoke.ContourArea(shape); // Detect each shape area
                    Rectangle boundingBox = CvInvoke.BoundingRectangle(shape); // Create a bounding box around every shape
                    Point center = new Point(boundingBox.X + boundingBox.Width / 2, boundingBox.Y + boundingBox.Height / 2); // Create a center point for each bounding box to be used for targeting
                    if (area > (paperArea - 3000) && area < (paperArea + 3000)) // paperArea is initialized in setup
                    {
                        // Identify the paper and modify ratio to detect inches instead of pixels
                        triORsq = "Unidentified";
                        pxToIn = boundingBox.Width / 11.0;
                        int distancetoCenterYBase = Convert.ToInt32(1.99 * pxToIn) + Convert.ToInt32(9 * pxToIn); // The base front is 9 inches from the paper, the distance from the front of the base to the start of the first link arm is 1.99
                        basePoint = new Point(center.X, center.Y + distancetoCenterYBase); // Creating a point at the center of the robot base
                        paperCenter = new Point(center.X, center.Y); // Store paper center for later use
                    }
                    else if (area > (triArea - 100) && area < (triArea + 200))
                    {
                        // Identify triangles and outline them in green, and display centers in purple
                        triORsq = "Triangle";
                        CvInvoke.Polylines(decoratedImage, shape, true, new Bgr(Color.Green).MCvScalar, 1);
                        CvInvoke.Circle(decoratedImage, center, 0, new Bgr(Color.Purple).MCvScalar, 3);
                    }
                    else if (area > (sqArea - 300) && area < (sqArea + 300))
                    {
                        // Identify Squares and outline them in red, and display centers in purple
                        triORsq = "Square";
                        CvInvoke.Polylines(decoratedImage, shape, true, new Bgr(Color.Red).MCvScalar, 1);
                        CvInvoke.Circle(decoratedImage, center, 0, new Bgr(Color.Purple).MCvScalar, 3);
                    }
                    else
                    {
                        // If the shape detected is not the paper, a triangle, or a square, do nothing
                        continue;
                    }
                    // Once all wanted shapes are identified, add them to shapeList
                    shapeList.Add(new Shape() { Label = i + 1, Area = area, TriSq = triORsq, Center = center });
                }
                foreach (Shape aShape in shapeList.ToList())
                {
                    // Display shapeList in Form
                    Invoke(new Action(() => { shapeInfoLabel.Text += $"{aShape}\n\n"; }));
                }
                try
                {
                    // Enclosed in a try-catch to avoid exceptions that did not affect the functionality of the program
                    Invoke(new Action(() => { processedPictureBox.Image = decoratedImage.ToBitmap(); }));
                }
                catch { }
            }
            
        }
        private void SquareVSTriangle(List<Shape> triangleList, List<Shape> squareList)
        {
            // Clear the triangleList to rid any overflow information, make a copy of the shapeList and store it in triangleList
            triangleList.Clear();
            triangleList.AddRange(shapeList.ToList());

            // Remove shapes from the list that aren't triangles
            while (triangleList.Contains(new Shape { TriSq = "Square" }) || triangleList.Contains(new Shape { TriSq = "Unidentified" }))
            {
                triangleList.Remove(new Shape { TriSq = "Square" });
                triangleList.Remove(new Shape { TriSq = "Unidentified" });
            }

            // Clear the squareList to rid any overflow information, make a copy of the shapeList and store it in squareList
            squareList.Clear();
            squareList.AddRange(shapeList.ToList());

            // Remove shapes from the list that aren't squares
            while (squareList.Contains(new Shape { TriSq = "Triangle" }) || squareList.Contains(new Shape { TriSq = "Unidentified" }))
            {
                squareList.Remove(new Shape { TriSq = "Triangle" });
                squareList.Remove(new Shape { TriSq = "Unidentified" });
            }

            // Display the triangleList and squareList
            foreach (Shape sq in squareList)
            {
                Invoke(new Action(() => { sqListLabel.Text += $"{sq}\n"; }));
            }
            foreach (Shape tri in triangleList)
            {
                Invoke(new Action(() => { triListLabel.Text += $"{tri}\n"; }));
            }
            shapeList.Clear(); // Clear the shapeList to prevent overflow data
        }
        private void ShapeFormatandSend(List<Shape> triangleList, List<Shape> squareList)
        { 
            // Parse squareList, send and display information
            foreach (Shape sq in squareList)
            {
                // If Arduino has moved and is ready for the next shape
                if (enableCoordinateSending && sq != null)
                {
                    // Find the X and Y distance in pixels from the center of the starting point
                    double sqX = sq.Center.X - basePoint.X;
                    double sqY = basePoint.Y - sq.Center.Y;

                    // Convert to inches
                    double sqXin = Math.Round(Convert.ToDouble(sqX) / pxToIn, 2);
                    double sqYin = Math.Round(Convert.ToDouble(sqY) / pxToIn, 2);

                    // Organize data for sending over serial and displaying in Form
                    toSend = "<" + sq.TriSq.ToString() + ", " + sqXin.ToString() + ", " + sqYin.ToString() + ">";
                    SendtoArduino(toSend); 
                    Invoke(new Action(() => { sentDataLogLabel.Text += $"{toSend}\n"; }));

                    // Ensure wait for enable from Arduino before sending the next shape
                    enableCoordinateSending = false;
                }
                else
                {
                    continue;
                }
            }

            // Same method as above
            foreach (Shape tri in triangleList)
            {
                if (enableCoordinateSending && tri != null)
                {
                    double triX = tri.Center.X - basePoint.X;
                    double triY = basePoint.Y - tri.Center.Y;

                    double triXin = Math.Round(Convert.ToDouble(triX) / pxToIn, 2);
                    double triYin = Math.Round(Convert.ToDouble(triY) / pxToIn, 2);

                    toSend = "<" + tri.TriSq.ToString() + ", " + triXin.ToString() + ", " + triYin.ToString() + ">";
                    SendtoArduino(toSend);
                    Invoke(new Action(() => { sentDataLogLabel.Text += $"{toSend}\n"; }));

                    enableCoordinateSending = false;
                }
                else
                {
                    continue;
                }
            }
        }
        private void SendtoArduino(string coords)
        {
            // Enclosed in a try-catch to avoid exceptions that did not affect the functionality of the program
            try
            {
                // Send data to Arduino over serial
                arduinoSerial.WriteLine(coords);
                Console.WriteLine(coords);
            }
            catch { }
        }
        private void MonitorSerialData()
        {
            while (true)
            {
                // Read information sent over serial from the Arduino, as long as there is information
                string msg = arduinoSerial.ReadLine();
                if(msg != null)
                {
                    // Only collect information that starts with < and ends with >
                    if (msg.IndexOf("<") == -1 || msg.IndexOf(">") == -1)
                    {
                        continue;
                    }
                    // Begin storing information after < for later use
                    msg = msg.Substring(msg.IndexOf("<") + 1);
                    // Remove ending character >
                    msg = msg.Remove(msg.IndexOf(">"));

                    // So long as there is information within < > continue
                    if (msg.Length == 0)
                    {
                        continue;
                    }

                    // An S or P from the Arduino will either enable or suspend communication respectively
                    if (msg.Substring(0, 1) == "S")
                    {
                        ToggleFieldAvailability(msg.Substring(1, 1) == "1");
                    }
                    else if (msg.Substring(0, 1) == "P")
                    {
                        Invoke(new Action(() => { receivedDataLogLabel.Text += $"{msg.Substring(1)}\n"; }));
                    }
                }
            }
        }
        private void ToggleFieldAvailability(bool suspend)
        {
            Invoke(new Action(() => 
            {
                // Depending on the state of suspend, Lock or Unlock communication and display state
                enableCoordinateSending = !suspend;
                lockStatusStripLabel.Text = $" State: {(suspend ? "Locked" : "Unlocked")}";
            }));
        }

        private void KernelSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            // Adjust kernel size of Gaussian Blur, 9 is generally a good value
            ksize = KernelSizeTrackBar.Value;
            if (ksize % 2 == 0)
            {
                ksize--;
                KernelSizeTrackBar.Value = ksize;
            }
            kernelSizeLabel.Text = "" + ksize;
        }
        private void MinThreshTrackBar_Scroll(object sender, EventArgs e)
        {
            // Adjust minimum threshold value of the Binary Threshold, 80-90 is generally a good range
            minThresh = MinThreshTrackBar.Value;
            minThreshLabel.Text = "" + minThresh;
        }
        private void MaxThreshTrackBar_Scroll(object sender, EventArgs e)
        {
            // Adjust maximum threshold value of the Binary Threshold, 255 is generally a good value
            maxThresh = MaxThreshTrackBar.Value;
            maxThreshLabel.Text = "" + maxThresh;
        }
        private void SendCoordsDebugButton_Click(object sender, EventArgs e)
        {
            // As long the Arduino is ready for information, send the manually inputted information
            if (enableCoordinateSending)
            {
                toSend = "<" + ShapeDebugTextBox.Text + ", " + XcoordsDebugTextBox.Text + ", " + YcoordsDebugTextBox.Text + ">";
                SendtoArduino(toSend);
                Invoke(new Action(() => { sentDataLogLabel.Text += $"{toSend}\n"; }));
                return;
            }
            
        }
        private void StartControlButton_Click(object sender, EventArgs e)
        {
            // Begin communiaction with Arduino
            enableCoordinateSending = true;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            captureThread.Abort();
            serialMonitoringThread.Abort();
        }
    }
    public class Shape : IEquatable<Shape>
    {
        // Store shape information and allow for access through ToString
        public int Label { get; set; }
        public double Area { get; set; }
        public string TriSq { get; set; }
        public Point Center { get; set; }
        public override string ToString()
        {
            return "Label: " + Label + ", Area: " + Area + ", Shape: " + TriSq + ", Center: " + Center;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null) return false;
            Shape objAsShape = obj as Shape;
            if (objAsShape == null) return false;
            else return Equals(objAsShape);
        }
        public override int GetHashCode()
        {
            return Label;
        }
        public bool Equals(Shape other)
        {
            if (other == null) return false;
            return (this.TriSq.Equals(other.TriSq));
        }
    }
}
