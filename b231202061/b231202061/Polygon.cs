
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
    internal class Polygon
    {
        private Point2D center;// Center point of the polygon
        private int length;// Distance from center to each vertex (like radius)
        private ColorRGB color;
        private int numberOfEdges;
        private Point2D[] vertices;// Array to store the calculated vertex positions


        #region Properties

        public Point2D Center { get => center; set => center = value; }

        public int Length// Property for the side length / radius (must be positive)
        {
            get => length;
            set
            {
                if (value <= 0)// Prevent negative or zero lengths
                    throw new ArgumentException("Length must be positive.", nameof(Length)); 
                length = value;
            }
        }
        public ColorRGB Color { get => color; set => color = value; }
        public int NumberOfEdges
        {
            get => numberOfEdges; set // Property for number of edges (must be between 3 and 10)
            {
                if (value < 3 || value > 10)
                    throw new ArgumentException("Number of edges must be between 3 and 10.", nameof(NumberOfEdges));// Enforce limits
                numberOfEdges = value;
            }
        }
        public Point2D[] Vertices { get => vertices; } // Read-only property to access vertices

        #endregion

        #region Constructers
        public Polygon()  // Default constructor: sets default values
        {
            center = new Point2D(0, 0);
            length = 4;
            color = new ColorRGB();// Default color (black)
            numberOfEdges = 5;
            vertices = new Point2D[numberOfEdges]; // Allocate vertex array
            CalculateEdgeCoordinates();// Calculate vertex positions
        }

        public Polygon(Point2D center, int length)// Constructor with center point and length as parameters
        {
            this.center = center;    // Set custom center
            this.Length = length;     // Use property to validate
            this.NumberOfEdges = 5;         // Fixed number of edges (5
            this.color = new ColorRGB();     // Default color (black)

            this.vertices = new Point2D[numberOfEdges];
            CalculateEdgeCoordinates(); // Calculate initial vertex positions

        }

        #endregion

        public void CalculateEdgeCoordinates() // Calculates positions of all vertices based on center, length, and number of edges
        {
            vertices = new Point2D[numberOfEdges];// Reallocate array in case edge count changed

             Random rnd = new Random();
             double firstVertexAngle = rnd.Next(0, 360); // Random angle between 0-359.First vertex point should start with a random integer point.
            // double firstVertexAngle = 0; //If you dont want to randomize initial angle you can use this. Starting angle in degrees (aligned with X axis)

            double angleBetweenVertices = 360.0 / numberOfEdges; // Angle between two vertices

            for (int i = 0; i < numberOfEdges; i++)
            {
                double angleInDegrees = firstVertexAngle + i * angleBetweenVertices;// Calculate angle of the current vertex
                double angleInRadians = angleInDegrees * Math.PI / 180;// Convert degrees to radians


                // Calculate X and Y positions using polar to Cartesian conversion
                double x = center.X + length * Math.Cos(angleInRadians);
                double y = center.Y + length * Math.Sin(angleInRadians);

                vertices[i] = new Point2D(x, y);// Store the vertex
            }
        }

        public void RotatePolygon(double rotationAngle, bool isCCW) // Rotates the polygon around its center by a given angle and direction (clockwise or counterclockwise)
        {

            //Determining the rotation angle.
            double angle;

            if (isCCW) // if CCW is checked // Counter-clockwise rotation
            {
                angle = rotationAngle; // Positive anglesince mathematically counterclockwise is considered positive.
            }
            else // If CCW is not selected (default)
            {
                angle = -rotationAngle; // Negative angle (reverse direction)
            }


            for (int i = 0; i < vertices.Length; i++)
            {
                double dx = vertices[i].X - center.X;//The position of the vertex relative to the center
                double dy = vertices[i].Y - center.Y;

                // Convert to polar
                double currentAngle = Math.Atan2(dy, dx); // In radians
                double distance = Math.Sqrt(dx * dx + dy * dy);//Calculates the distance from the center to the vertex.

                double newAngle = currentAngle + angle * Math.PI / 180;   // Add the rotation to the current angle
                                                                          // Convert angle to radians

                // Convert back to Cartesian coordinates
                double newX = center.X + distance * Math.Cos(newAngle);
                double newY = center.Y + distance * Math.Sin(newAngle);

                vertices[i] = new Point2D(newX, newY);// Store the new rotated vertex
            }


        }





    }
}
