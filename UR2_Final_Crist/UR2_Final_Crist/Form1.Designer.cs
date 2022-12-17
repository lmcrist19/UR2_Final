namespace UR2_Final_Crist
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rawPictureBox = new System.Windows.Forms.PictureBox();
            this.processedPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaxThreshTrackBar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.XcoordsDebugTextBox = new System.Windows.Forms.TextBox();
            this.YcoordsDebugTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sendCoordsDebugButton = new System.Windows.Forms.Button();
            this.lockStatusStrip = new System.Windows.Forms.StatusStrip();
            this.lockStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.receivedDataLogLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.shapeInfoLabel = new System.Windows.Forms.Label();
            this.shapeCountLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.blurPictureBox = new System.Windows.Forms.PictureBox();
            this.binaryPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KernelSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.MinThreshTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minThreshLabel = new System.Windows.Forms.Label();
            this.maxThreshLabel = new System.Windows.Forms.Label();
            this.kernelSizeLabel = new System.Windows.Forms.Label();
            this.sqListLabel = new System.Windows.Forms.Label();
            this.triListLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ShapeDebugTextBox = new System.Windows.Forms.TextBox();
            this.StartControlButton = new System.Windows.Forms.Button();
            this.sentDataLogLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rawPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxThreshTrackBar)).BeginInit();
            this.lockStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blurPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KernelSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinThreshTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // rawPictureBox
            // 
            this.rawPictureBox.Location = new System.Drawing.Point(17, 24);
            this.rawPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rawPictureBox.Name = "rawPictureBox";
            this.rawPictureBox.Size = new System.Drawing.Size(225, 183);
            this.rawPictureBox.TabIndex = 0;
            this.rawPictureBox.TabStop = false;
            // 
            // processedPictureBox
            // 
            this.processedPictureBox.Location = new System.Drawing.Point(517, 24);
            this.processedPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.processedPictureBox.Name = "processedPictureBox";
            this.processedPictureBox.Size = new System.Drawing.Size(225, 183);
            this.processedPictureBox.TabIndex = 3;
            this.processedPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Raw";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Processed";
            // 
            // MaxThreshTrackBar
            // 
            this.MaxThreshTrackBar.LargeChange = 10;
            this.MaxThreshTrackBar.Location = new System.Drawing.Point(266, 551);
            this.MaxThreshTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaxThreshTrackBar.Maximum = 255;
            this.MaxThreshTrackBar.Name = "MaxThreshTrackBar";
            this.MaxThreshTrackBar.Size = new System.Drawing.Size(225, 45);
            this.MaxThreshTrackBar.SmallChange = 5;
            this.MaxThreshTrackBar.TabIndex = 11;
            this.MaxThreshTrackBar.Value = 255;
            this.MaxThreshTrackBar.Scroll += new System.EventHandler(this.MaxThreshTrackBar_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 215);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Debug Serial Communication";
            // 
            // XcoordsDebugTextBox
            // 
            this.XcoordsDebugTextBox.Location = new System.Drawing.Point(64, 258);
            this.XcoordsDebugTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.XcoordsDebugTextBox.Name = "XcoordsDebugTextBox";
            this.XcoordsDebugTextBox.Size = new System.Drawing.Size(76, 20);
            this.XcoordsDebugTextBox.TabIndex = 16;
            // 
            // YcoordsDebugTextBox
            // 
            this.YcoordsDebugTextBox.Location = new System.Drawing.Point(64, 280);
            this.YcoordsDebugTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YcoordsDebugTextBox.Name = "YcoordsDebugTextBox";
            this.YcoordsDebugTextBox.Size = new System.Drawing.Size(76, 20);
            this.YcoordsDebugTextBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 262);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 284);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Y";
            // 
            // sendCoordsDebugButton
            // 
            this.sendCoordsDebugButton.Location = new System.Drawing.Point(154, 257);
            this.sendCoordsDebugButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendCoordsDebugButton.Name = "sendCoordsDebugButton";
            this.sendCoordsDebugButton.Size = new System.Drawing.Size(56, 19);
            this.sendCoordsDebugButton.TabIndex = 20;
            this.sendCoordsDebugButton.Text = "Send";
            this.sendCoordsDebugButton.UseVisualStyleBackColor = true;
            this.sendCoordsDebugButton.Click += new System.EventHandler(this.SendCoordsDebugButton_Click);
            // 
            // lockStatusStrip
            // 
            this.lockStatusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.lockStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lockStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockStatusStripLabel});
            this.lockStatusStrip.Location = new System.Drawing.Point(0, 655);
            this.lockStatusStrip.Name = "lockStatusStrip";
            this.lockStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.lockStatusStrip.Size = new System.Drawing.Size(760, 22);
            this.lockStatusStrip.TabIndex = 22;
            this.lockStatusStrip.Text = "State: ";
            // 
            // lockStatusStripLabel
            // 
            this.lockStatusStripLabel.Name = "lockStatusStripLabel";
            this.lockStatusStripLabel.Size = new System.Drawing.Size(39, 17);
            this.lockStatusStripLabel.Text = "State: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 303);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Sent";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 441);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Received";
            // 
            // receivedDataLogLabel
            // 
            this.receivedDataLogLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.receivedDataLogLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receivedDataLogLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.receivedDataLogLabel.Location = new System.Drawing.Point(17, 455);
            this.receivedDataLogLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.receivedDataLogLabel.Name = "receivedDataLogLabel";
            this.receivedDataLogLabel.Size = new System.Drawing.Size(226, 118);
            this.receivedDataLogLabel.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(577, 217);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Shapes";
            // 
            // shapeInfoLabel
            // 
            this.shapeInfoLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.shapeInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shapeInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.shapeInfoLabel.Location = new System.Drawing.Point(517, 310);
            this.shapeInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shapeInfoLabel.Name = "shapeInfoLabel";
            this.shapeInfoLabel.Size = new System.Drawing.Size(226, 263);
            this.shapeInfoLabel.TabIndex = 28;
            // 
            // shapeCountLabel
            // 
            this.shapeCountLabel.AutoSize = true;
            this.shapeCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeCountLabel.Location = new System.Drawing.Point(588, 238);
            this.shapeCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shapeCountLabel.Name = "shapeCountLabel";
            this.shapeCountLabel.Size = new System.Drawing.Size(24, 26);
            this.shapeCountLabel.TabIndex = 29;
            this.shapeCountLabel.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(573, 268);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "Set Area";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(514, 296);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 13);
            this.label21.TabIndex = 36;
            this.label21.Text = "Shape Information";
            // 
            // blurPictureBox
            // 
            this.blurPictureBox.Location = new System.Drawing.Point(266, 24);
            this.blurPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.blurPictureBox.Name = "blurPictureBox";
            this.blurPictureBox.Size = new System.Drawing.Size(225, 183);
            this.blurPictureBox.TabIndex = 1;
            this.blurPictureBox.TabStop = false;
            // 
            // binaryPictureBox
            // 
            this.binaryPictureBox.Location = new System.Drawing.Point(266, 294);
            this.binaryPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.binaryPictureBox.Name = "binaryPictureBox";
            this.binaryPictureBox.Size = new System.Drawing.Size(225, 183);
            this.binaryPictureBox.TabIndex = 2;
            this.binaryPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Blur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Binary Threshold";
            // 
            // KernelSizeTrackBar
            // 
            this.KernelSizeTrackBar.LargeChange = 4;
            this.KernelSizeTrackBar.Location = new System.Drawing.Point(266, 234);
            this.KernelSizeTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KernelSizeTrackBar.Maximum = 49;
            this.KernelSizeTrackBar.Minimum = 1;
            this.KernelSizeTrackBar.Name = "KernelSizeTrackBar";
            this.KernelSizeTrackBar.Size = new System.Drawing.Size(225, 45);
            this.KernelSizeTrackBar.SmallChange = 2;
            this.KernelSizeTrackBar.TabIndex = 8;
            this.KernelSizeTrackBar.Value = 9;
            this.KernelSizeTrackBar.Scroll += new System.EventHandler(this.KernelSizeTrackBar_Scroll);
            // 
            // MinThreshTrackBar
            // 
            this.MinThreshTrackBar.AllowDrop = true;
            this.MinThreshTrackBar.LargeChange = 10;
            this.MinThreshTrackBar.Location = new System.Drawing.Point(266, 502);
            this.MinThreshTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinThreshTrackBar.Maximum = 255;
            this.MinThreshTrackBar.Name = "MinThreshTrackBar";
            this.MinThreshTrackBar.Size = new System.Drawing.Size(225, 45);
            this.MinThreshTrackBar.SmallChange = 5;
            this.MinThreshTrackBar.TabIndex = 10;
            this.MinThreshTrackBar.Value = 80;
            this.MinThreshTrackBar.Scroll += new System.EventHandler(this.MinThreshTrackBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kernel Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 486);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Minimum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(264, 534);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Maximum";
            // 
            // minThreshLabel
            // 
            this.minThreshLabel.AutoSize = true;
            this.minThreshLabel.Location = new System.Drawing.Point(317, 486);
            this.minThreshLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minThreshLabel.Name = "minThreshLabel";
            this.minThreshLabel.Size = new System.Drawing.Size(19, 13);
            this.minThreshLabel.TabIndex = 37;
            this.minThreshLabel.Text = "80";
            // 
            // maxThreshLabel
            // 
            this.maxThreshLabel.AutoSize = true;
            this.maxThreshLabel.Location = new System.Drawing.Point(320, 534);
            this.maxThreshLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxThreshLabel.Name = "maxThreshLabel";
            this.maxThreshLabel.Size = new System.Drawing.Size(25, 13);
            this.maxThreshLabel.TabIndex = 38;
            this.maxThreshLabel.Text = "255";
            // 
            // kernelSizeLabel
            // 
            this.kernelSizeLabel.AutoSize = true;
            this.kernelSizeLabel.Location = new System.Drawing.Point(333, 215);
            this.kernelSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kernelSizeLabel.Name = "kernelSizeLabel";
            this.kernelSizeLabel.Size = new System.Drawing.Size(13, 13);
            this.kernelSizeLabel.TabIndex = 39;
            this.kernelSizeLabel.Text = "9";
            // 
            // sqListLabel
            // 
            this.sqListLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.sqListLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sqListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sqListLabel.Location = new System.Drawing.Point(17, 599);
            this.sqListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sqListLabel.Name = "sqListLabel";
            this.sqListLabel.Size = new System.Drawing.Size(362, 50);
            this.sqListLabel.TabIndex = 40;
            // 
            // triListLabel
            // 
            this.triListLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.triListLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.triListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.triListLabel.Location = new System.Drawing.Point(383, 599);
            this.triListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.triListLabel.Name = "triListLabel";
            this.triListLabel.Size = new System.Drawing.Size(359, 50);
            this.triListLabel.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(582, 583);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Triangles List:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(86, 583);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Squares List:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 239);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Shape";
            // 
            // ShapeDebugTextBox
            // 
            this.ShapeDebugTextBox.Location = new System.Drawing.Point(64, 235);
            this.ShapeDebugTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShapeDebugTextBox.Name = "ShapeDebugTextBox";
            this.ShapeDebugTextBox.Size = new System.Drawing.Size(76, 20);
            this.ShapeDebugTextBox.TabIndex = 44;
            // 
            // StartControlButton
            // 
            this.StartControlButton.Location = new System.Drawing.Point(643, 220);
            this.StartControlButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartControlButton.Name = "StartControlButton";
            this.StartControlButton.Size = new System.Drawing.Size(56, 56);
            this.StartControlButton.TabIndex = 46;
            this.StartControlButton.Text = "Start";
            this.StartControlButton.UseVisualStyleBackColor = true;
            this.StartControlButton.Click += new System.EventHandler(this.StartControlButton_Click);
            // 
            // sentDataLogLabel
            // 
            this.sentDataLogLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.sentDataLogLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sentDataLogLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sentDataLogLabel.Location = new System.Drawing.Point(17, 317);
            this.sentDataLogLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sentDataLogLabel.Name = "sentDataLogLabel";
            this.sentDataLogLabel.Size = new System.Drawing.Size(226, 118);
            this.sentDataLogLabel.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 677);
            this.Controls.Add(this.StartControlButton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ShapeDebugTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.triListLabel);
            this.Controls.Add(this.sqListLabel);
            this.Controls.Add(this.kernelSizeLabel);
            this.Controls.Add(this.maxThreshLabel);
            this.Controls.Add(this.minThreshLabel);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.shapeCountLabel);
            this.Controls.Add(this.shapeInfoLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.receivedDataLogLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lockStatusStrip);
            this.Controls.Add(this.sentDataLogLabel);
            this.Controls.Add(this.sendCoordsDebugButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.YcoordsDebugTextBox);
            this.Controls.Add(this.XcoordsDebugTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MaxThreshTrackBar);
            this.Controls.Add(this.MinThreshTrackBar);
            this.Controls.Add(this.KernelSizeTrackBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processedPictureBox);
            this.Controls.Add(this.binaryPictureBox);
            this.Controls.Add(this.blurPictureBox);
            this.Controls.Add(this.rawPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unified Robotics II";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rawPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxThreshTrackBar)).EndInit();
            this.lockStatusStrip.ResumeLayout(false);
            this.lockStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blurPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KernelSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinThreshTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rawPictureBox;
        private System.Windows.Forms.PictureBox processedPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar MaxThreshTrackBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox XcoordsDebugTextBox;
        private System.Windows.Forms.TextBox YcoordsDebugTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button sendCoordsDebugButton;
        private System.Windows.Forms.StatusStrip lockStatusStrip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label receivedDataLogLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label shapeInfoLabel;
        private System.Windows.Forms.Label shapeCountLabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox blurPictureBox;
        private System.Windows.Forms.PictureBox binaryPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar KernelSizeTrackBar;
        private System.Windows.Forms.TrackBar MinThreshTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label minThreshLabel;
        private System.Windows.Forms.Label maxThreshLabel;
        private System.Windows.Forms.Label kernelSizeLabel;
        private System.Windows.Forms.ToolStripStatusLabel lockStatusStripLabel;
        private System.Windows.Forms.Label sqListLabel;
        private System.Windows.Forms.Label triListLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ShapeDebugTextBox;
        private System.Windows.Forms.Button StartControlButton;
        private System.Windows.Forms.Label sentDataLogLabel;
    }
}

