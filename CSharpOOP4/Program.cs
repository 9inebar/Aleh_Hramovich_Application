// See https://aka.ms/new-console-template for more information

using CSharpOOP4;

//Ball class object calling Shape's class both virtual and abstract methods
Ball myBall = new Ball("Soccer Ball",5);
myBall.PrintShapeInfo();

//Pyramid class object calling Shape's class both virtual and abstract methods
Pyramid myPyramid = new Pyramid("GizaPyramid", 146, 53000);
myPyramid.PrintShapeInfo();

//Cylinder class object calling Shape's class both virtual and abstract methods
Cylinder myCylinder = new Cylinder("carCylinder",2,3);
myCylinder.PrintShapeInfo();