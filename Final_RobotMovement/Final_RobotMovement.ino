#include <VarSpeedServo.h>
#include <AccelStepper.h>
#include <MultiStepper.h>

// Link 2 starts at 12.2 deg
// Link 1 starts at 0 deg

#define in1 10
#define in2 11
#define in3 12
#define in4 13
#define magnet 8
#define arm2 6
#define arm1 5

#define interface 8

// Initialize motors
AccelStepper baseRotate = AccelStepper(interface, in1, in3, in2, in4);
VarSpeedServo armOne;
VarSpeedServo armTwo;

const byte numChars = 32;
char receivedShape[numChars];
char tempShapeStorage[numChars];
char shape[numChars] = {0};

float xDist = 0;
float yDist = 0;
double baseAngle = 0;
double shapeDist = 0;
double pi = 3.14159265358;

double L1 = 5.7015748; // Height to Link 1
double L2 = 8.93701; // Length of Link 1
double L3 = 8.70395; // Length of Link 2
double th1 = 0;
double th2 = 0;
double degtoTouch = 0;
double fullStretch = 0;
double x = 0;
double y = 0;

double baseDeg = (4115/360);

bool continueRotate = true;
bool newShape = false;

void setup(){
  Serial.begin(9600);

  // Must include since start position is standardly 93, overrides and sets start to 0
  armOne.write(0); 
  armTwo.write(0);

  // Set pins
  armOne.attach(arm1);
  armTwo.attach(arm2);
  pinMode(magnet, OUTPUT);

  // Initialize movement for base rotation
  baseRotate.setMaxSpeed(1000);
  baseRotate.setAcceleration(500);
}
void loop(){
  receiveShapeData();
  if (newShape) {
    sendSuspendCmd();
    parseData();
    doMath();
    sendData();
    moveRobot();
    delay(1000);
    digitalWrite(magnet, HIGH); // Turn on the magnet
    touch();   
      // If the shape is a triangle, return to start angle, rotate 90 degrees (right), drop shape   
      if(shape[0] == 'T'){
        baseAngle = -baseAngle;
        baseRotate.setSpeed(300); // 300 was a good speed
        baseRotate.move(-baseAngle*baseDeg);
        baseRotate.runToPosition();
        delay(1000);
        shapePilePosition();
        doMath();
        baseAngle = 90;
        moveRobot();
        delay(1000);
        digitalWrite(magnet, LOW);
        resetPosition();
        moveRobot();
      }
      // Same as above but for Square and -90 degrees (left)
      else if(shape[0] == 'S'){
        baseAngle = -baseAngle;
        baseRotate.setSpeed(300);
        baseRotate.move(-baseAngle*baseDeg);
        baseRotate.runToPosition();
        delay(1000);
        shapePilePosition();
        doMath();
        baseAngle = -90;
        moveRobot();
        delay(1000);
        digitalWrite(magnet, LOW);        
        resetPosition();
        moveRobot();
      }
    newShape = false; // After run through of first shape, tell the Arduino there are no new shapes
    sendEnableCmd();
  }
}
void sendSuspendCmd(){
  // Send command to C# to stop communication and not allow coordinate sending
  Serial.println("<S1>");
}
void sendEnableCmd(){
  // Send command to C# to start communication and allow coordinate sending
  Serial.println("<S0>");
}
void receiveShapeData(){
  // Store received data from C# so long as it fits the conditions
  static bool receiving = false;
  static byte index = 0;
  char receivedFromPC;

  while (Serial.available() > 0 && newShape == false){
    receivedFromPC = Serial.read();
    if (receiving == true){
      if(receivedFromPC != '>'){
        receivedShape[index] = receivedFromPC;
        index++;
        if(index >= numChars){
          index = numChars - 1;
        }
      }
      else { 
        receivedShape[index] = '\0';
        receiving = false;
        index = 0;
        newShape = true;
      }
    }
    else if (receivedFromPC == '<'){
      receiving = true;
    }
  }
  strcpy(tempShapeStorage, receivedShape);
}
void parseData(){
  // Parse through stored shape data and organize it into its respective components
  char *shapeToken;

  shapeToken = strtok(tempShapeStorage, ",");
  strcpy(shape, shapeToken);

  shapeToken = strtok(NULL, ",");
  xDist = atof(shapeToken);

  shapeToken = strtok(NULL, ",");
  yDist = atof(shapeToken);
}
void sendData(){
  // Send calculated data and received data back to C# fro debugging
  Serial.print("<PSh: ");
  Serial.print(shape);
  Serial.print("; ");
  Serial.print("Ce: ");
  Serial.print(xDist);
  Serial.print(", ");
  Serial.print(yDist);
  Serial.print("; ");
  Serial.print("An: ");
  Serial.print(baseAngle);
  Serial.print("; ");
  Serial.print("Di: ");
  Serial.print(shapeDist);
  Serial.print("; ");
  Serial.print("St: ");
  Serial.print(fullStretch);
  Serial.print("; ");
  Serial.print("Th1: ");
  Serial.print(th1);
  Serial.print("; ");
  Serial.print("Th2: ");
  Serial.print(th2);
  Serial.print("; ");
  Serial.print("To: ");
  Serial.print(degtoTouch);
  Serial.println(">");
}
void doMath(){
  baseAngle = radtoDeg(atan(xDist/yDist)); // Rotation angle of the base
  shapeDist = hypot(xDist, yDist); // Distance from the start of the first arm link to the shape
  fullStretch = hypot(L1, shapeDist); // L1 is the height of the first arm link, calculates new shape distance with touch rotation accounted for

  // Calculate the angle of the arm links using law of cosines
  th2 = acos((sq(fullStretch)-sq(L2)-sq(L3))/(2.0*L2*L3)); 
  th1 = atan((L3*sin(th2))/(L2+L3*cos(th2)));

  // Compensate for starting values and error based on data collection
  th2 = (180.0-radtoDeg(th2)-15.686)/0.768;
  th1 = (90.0 - radtoDeg(th1)-3.6179)/0.9769;

  // Calculate touch rotation for the first arm link to rotate and touch the shape
  degtoTouch = radtoDeg(atan(L1/fullStretch))-5.0;
}
void moveRobot(){
  // Move robot to calculated positions
  baseRotate.setSpeed(300);
  baseRotate.move(-baseAngle*baseDeg);
  baseRotate.runToPosition();
  armTwo.write(th2, 70, false);
  armOne.write(th1, 50, true);
}
void touch(){
  // Rotate to touch shape
  armOne.write(th1+degtoTouch, 50, true);
  delay(2000);
  armOne.write(30, 50, true);
}
void shapePilePosition(){
  // Set position of piles 4 inches from the center of the base
  xDist = 0;
  yDist = 4;
}
void resetPosition(){
  // Reset position of robot
  if(shape[0]=='T'){
    baseAngle = -90;
  }
  else{
    baseAngle = 90;    
  }
  shapeDist = 0;
  fullStretch = 0;
  th1 = 0;
  th2 = 0;
  degtoTouch = 0;
}
double radtoDeg(double rad){
  // Convert values frfom radians to degrees
  double deg = rad*(180/pi);
  return deg;
}
double degtoRad(double deg){
  // Convert values from degrees to radians
  double rad = deg*(pi/180);
  return rad;  
}
