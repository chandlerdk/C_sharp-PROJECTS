using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* CHANDLER DUKE. COMP LANG 1.
 * THIS PROGRAM USES WINDOWS FORM TO REQUEST SHAPE DIMENSIONS FROM USER AND CALCULATE AREA
 */

//DATA LAYER AND SHAPE OBJECTS
namespace WinFormsApp4
{
    //Rectangle object
    public class Rectangle
    {
        private int rectangleHeight;
        private int rectangleWidth;
        private double rectangleArea;

        public Rectangle()
        {
        }

        public Rectangle(int rHeight, int rWidth, double rArea)
        {
            this.rectangleHeight = rHeight;
            this.rectangleWidth = rWidth;
            this.rectangleArea = rArea;
        }

        public int GetrHeight()
        {
            return this.rectangleHeight;
        }

        public void SetrHeight(int heightVal)
        {
            this.rectangleHeight = heightVal;
        }
        public int GetrWidth()
        {
            return this.rectangleWidth;
        }

        public void SetrWidth(int widthVal)
        {
            this.rectangleWidth = widthVal;
        }

        public double GetrArea()
        {
            return this.rectangleArea;
        }

        public void SetrArea(double areaVal)
        {
            this.rectangleArea = areaVal;
        }
    }

    //Circle Object
    public class Circle
    {
        private int circleRadius;
        private double circleArea;

        public Circle()
        {
        }

        public Circle(int cRadius, double cArea)
        {
            this.circleRadius = cRadius;
            this.circleArea = cArea;
        }

        public int GetcRadius()
        {
            return this.circleRadius;
        }

        public void SetcirRadius(int radiusVal)
        {
            this.circleRadius = radiusVal;
        }
        public double GetcirArea()
        {
            return this.circleArea;
        }

        public void SetcirArea(double areaVal)
        {
            this.circleArea = areaVal;
        }
    }

    //Cylinder object
    public class Cylinder
    {
        private int cylinderHeight;
        private int cylinderRadius;
        private double cylinderArea;

        public Cylinder()
        {
        }

        public Cylinder(int cylHeight, int cylRadius, double cylArea)
        {
            this.cylinderHeight = cylHeight;
            this.cylinderRadius = cylRadius;
            this.cylinderArea = cylArea;
        }

        public int GetCylHeight()
        {
            return this.cylinderHeight;
        }

        public void SetCylHeight(int cylHeightVal)
        {
            this.cylinderHeight = cylHeightVal;
        }
        public int GetCylRadius()
        {
            return this.cylinderRadius;
        }

        public void SetCylRadius(int cylRadiusVal)
        {
            this.cylinderRadius = cylRadiusVal;
        }
        public double GetCylArea()
        {
            return this.cylinderArea;
        }

        public void SetCylArea(double cylAreaVal)
        {
            this.cylinderArea = cylAreaVal;
        }
    }


}
