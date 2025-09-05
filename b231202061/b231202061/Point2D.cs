
//********************************************************************************
//**************       STUDENT NAME : ELİF GÜL ARSLAN ****************************
//**************     STUDENT NUMBER : B231202061      ****************************
//********************************************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b231202061
{
    internal class Point2D
    {

        //private fields
        private double x;// Coordinate value on the X-axis (Cartesian coordinate system)
        private double y;// Coordinate value on the Y-axis (Cartesian coordinate system)

        private double r;// Radius value in the polar coordinate system (distance from the origin)
        private double theta;// Angle value in the polar coordinate system (in degrees, counterclockwise from the x-axis)

       


        #region Properties
        ///<summary> Each variable's properties.Automatically updates polar and cartesian coordinates when set. </summary>
        public double X { get => x; set { x = value; calculatePolarCoordinates(); } } 
        public double Y { get => y; set { y = value; calculatePolarCoordinates(); } }


        public double R { get => r; set { r = value; calculateCartesianCoordinates(); } }
        public double Theta { get => theta; set { theta = value; calculateCartesianCoordinates(); } }

        #endregion

        #region Constructers

        // Constructor with paramaters
        // that initializes the point with Cartesian coordinates
        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;

        }


        // Second Constructor with random paramaters
        // that initializes the point with random or zero coordinates
        public Point2D(bool random)
        {
            if (random)
            {
                Random rnd = new();
                X = rnd.Next(0, 4);
                Y = rnd.Next(0, 4);// Generates a number 0,1,2 and 3.
            }
            else
            {
                X = 0; // Automatically updates polar coordinates
                Y = 0;
            }
        }

        #endregion


        // Converts current Cartesian coordinates to polar (r, theta)
        public void calculatePolarCoordinates()
        {
            r = Math.Sqrt(x * x + y * y);     // r = √(x² + y²)

            theta = Math.Atan2(y, x) * 180 / Math.PI;// theta = arctangent(y / x), converted to degrees because it is more readable than radians. 

        }

        // Converts current polar coordinates to Cartesian (x, y)
        public void calculateCartesianCoordinates()
        {
            double thetaRad = theta * (Math.PI / 180); // Convert angle from degrees to radians to accurate calculation
            x = r * Math.Cos(thetaRad); // Calculate X coordinate
            y = r * Math.Sin(thetaRad); // Calculate y coordinate
        }


        // Returns the Cartesian coordinates as a formatted string
        public string printCoordinates()
        {
             
            return "(" + X.ToString("F2") + ", " + Y.ToString("F2") + ")"; // F2 formats the number to 2 decimal places (e.g., 3.14159 becomes 3.14)
        }

        
        public string printPolarCoordinates()// Returns the polar coordinates as a formatted string
        {
      
            return "Polar Coordinates: (R: " + r + ", Theta: " + theta + "°)";

        }




    }
}
