
//********************************************************************************
//**************       STUDENT NAME : ELÝF GÜL ARSLAN ****************************
//**************     STUDENT NUMBER : B231202061      ****************************
//********************************************************************************



namespace b231202061
{
    public partial class Form1 : Form
    {
        


        private Polygon? polygon;
        // The current polygon object that holds the shape data.
        // It is nullable (indicated by '?') because initially there might be no polygon created yet.
        // This allows us to check if a polygon exists before performing operations on it.


        private double totalRotationAngle = 0;  // Total rotation angle


        // Fields to store the last valid values

        // Stores the last valid value entered for the Center X coordinate.
        // If the user inputs an invalid value, the form reverts to this value.
        private int lastValidCenterX = 0;

        // Stores the last valid value entered for the Center Y coordinate.
        // If the user inputs an invalid value, the form reverts to this value.
        private int lastValidCenterY = 0;

        // Stores the last valid value entered for the polygon's edge length.
        // If the user enters a value outside the allowed range, this value is used instead.
        private int lastValidLength = 4;


        public Form1()
        {
            InitializeComponent();
            InitializeDefaults();
        }
        private void Form1_Load(object sender, EventArgs e) //This method is automatically called when the form is first load
        {
            //For blank picturebox

            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);// Create a new blank Bitmap with the same dimensions as the PictureBox
            using (Graphics g = Graphics.FromImage(bitmap))// Use a Graphics object to draw on the Bitmap
            {
                g.Clear(Color.White); // Fill the entire bitmap with white color to simulate a clean background
            }
            pictureBox.Image = bitmap;   // Set the blank bitmap as the image shown in the PictureBox

        }


        // Sets the default values of the input controls (textboxes and trackbars)
        private void InitializeDefaults() // We can also set these values from the Properties window 
        {
            txtCenterX.Text = "0";
            txtCenterY.Text = "0";
            txtLength.Text = "4";
            txtNumberOfEdges.Text = "5";
            txtRotationAngle.Text = "30";

            trackBarRed.Value = 0; // Default value is black
            trackBarGreen.Value = 0;
            trackBarBlue.Value = 0;

            checkBoxCCW.Checked = false;// Default rotation direction is clockwise

        }



        #region RGB Color TrackBar Events

        /// <summary>
        /// Instantly assigns the selected color to the polygon via the trackbars and redraws it with the new color.
        /// Also prevents all three RGB values from being 255 at the same time, since a fully white polygon would be invisible.
        /// </summary>

        #region Red
        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            // Prevent setting all RGB values to 255 (which makes the polygon invisible on white background)
            if (trackBarRed.Value == 255 && trackBarGreen.Value == 255 && trackBarBlue.Value == 255)
            {
                trackBarRed.Value = 200; // Red color is decreased to seeing it
                MessageBox.Show("White color is invisible! RGB values cannot all be 255.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            // If a polygon exists, update its red color and redraw
            if (polygon != null)
            {
                polygon.Color.Red = trackBarRed.Value;
                DrawPolygon();
            }
        }
        #endregion

        #region Green

        // Same logic for green trackbar of the polygon color
        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            if (trackBarRed.Value == 255 && trackBarGreen.Value == 255 && trackBarBlue.Value == 255)
            {
                trackBarGreen.Value = 200;
                MessageBox.Show("White color is invisible! RGB values cannot all be 255.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (polygon != null)
            {
                polygon.Color.Green = trackBarGreen.Value;
                DrawPolygon();
            }
        }
        #endregion

        #region Blue
        // Same logic for blue trackbar of the polygon color
        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            if (trackBarRed.Value == 255 && trackBarGreen.Value == 255 && trackBarBlue.Value == 255)
            {
                trackBarBlue.Value = 200;
                MessageBox.Show("White color is invisible! RGB values cannot all be 255.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (polygon != null)
            {
                polygon.Color.Blue = trackBarBlue.Value;
                DrawPolygon();
            }
        }
        #endregion


        #endregion 


        #region Buton Click Events

        /// <summary>
        /// Handles the core user interactions: drawing a polygon, rotating it, and resetting the form with random values.
        ///  btnDraw_Click: Reads user inputs, creates a polygon, and draws it on the canvas.
        ///  btnRotate_Click: Rotates the existing polygon by the specified angle and direction.
        ///  btnReset_Click: Generates and assigns random values for the polygon’s properties and redraws it.
        /// Includes validation, error handling, and user feedback for a smooth experience.
        /// </summary>

        #region DRAW

        // This method is called when the "Draw" button is clicked
        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {   
                // Read and validate CenterX
                int centerX = int.Parse(txtCenterX.Text);// Read the user input for center X coordinate
                if (centerX < 0 || centerX > 3)// Check if centerX is out of valid range (0 to 3)
                {
                    MessageBox.Show("CenterX must be between 0 and 3.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCenterX.Text = lastValidCenterX.ToString(); /// Revert textbox to last valid value
                    return;// Stop execution if input is invalid
                }
                else
                {
                    lastValidCenterX = centerX; // update last valid value
                }

                // Read and validate CenterY
                int centerY = int.Parse(txtCenterY.Text);
                if (centerY < 0 || centerY > 3)// Check if centerY is out of valid range (0 to 3)
                {
                    MessageBox.Show("CenterY must be between 0 and 3.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCenterY.Text = lastValidCenterY.ToString(); // Revert to last valid Y value
                    return;
                }
                else
                {
                    lastValidCenterY = centerY;
                }

                // Read and validate Length
                int length = int.Parse(txtLength.Text);
                if (length < 3 || length > 9)
                {
                    MessageBox.Show("Length must be between 3 and 9.", "Invalid Length", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLength.Text = lastValidLength.ToString(); // Revert to last valid length
                    return;
                }
                else
                {
                    lastValidLength = length;// Update last valid length
                }




                // Read number of edges and RGB color values from the form and trackbar
                int edges = int.Parse(txtNumberOfEdges.Text);// Number of polygon sides

                int red = trackBarRed.Value;// Red component (0–255)
                int green = trackBarGreen.Value;// Green component (0–255)
                int blue = trackBarBlue.Value; // Blue component (0–255)


                // Create center point and color objects
                Point2D center = new Point2D(centerX, centerY);
                ColorRGB color = new ColorRGB(red, green, blue);

                // Instantiate a new polygon with the center and edge length
                polygon = new Polygon(center, length);


                // Set additional properties separately (not in constructor) 
                // This allows them to be changed later if needed
                // If we assign it within the constructor parameters, we won’t be able to modify it later 
                polygon.NumberOfEdges = edges;
                polygon.Color = color;

                // Calculate the vertex positions of the polygon
                polygon.CalculateEdgeCoordinates();

                totalRotationAngle = 0; // Reset total rotation angle to 0 when a new polygon is drawn
                labelTotalRotation.Text = $"Total Rotation Angle: {totalRotationAngle}°";

                DrawPolygon();  // Draw the polygon
                DisplayVertices(); // Show vertex coordinates in ListBox
            }
            catch (Exception ex)
            {
                // Display any unexpected errors (e.g., invalid number format or empty input)
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        #endregion

        #region ROTATE
        private void btnRotate_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the text input from the rotation angle textbox, removing any leading or trailing whitespace
                int angle = int.Parse(txtRotationAngle.Text.Trim());

                if (angle <= 0 || angle > 360)// Check if the angle is outside the valid range (less than or equal to 0 or greater than 360)
                {

                    // Show a warning message to the user that the angle must be within the range of 1 to 360 degrees
                    MessageBox.Show("Angle must be between 1 and 360.", "Invalid Angle", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return; // Exit the method early since the input is not valid
                }

                if (polygon == null) // if no polygon has been drawn yet
                {
                    MessageBox.Show("Please draw a polygon first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnReset_Click(sender, e); // automatically trigger the reset button and draw random polygon
                    return;// the user can press the rotate button again afterwards
                }


                // Check rotation direction (true = CCW, false = CW)
                bool ccw = checkBoxCCW.Checked;

                // Rotate the polygon
                polygon.RotatePolygon(angle, ccw);

                // Update and normalize total rotation angle
                totalRotationAngle += angle; // At this point, the angle is positive, so we add it to the total.
                totalRotationAngle = totalRotationAngle % 360; // Normalize the angle with 360 degrees (keep it within 0-360)

                // Display the total rotated angle on the label
                labelTotalRotation.Text = $"Total Rotation Angle: {totalRotationAngle}°";

                DrawPolygon();// Redraw the rotated polygon
                DisplayVertices();
            }

            catch (FormatException) //runs if the user enters a non-numeric value (such as a letter, space, or symbol) into the txtRotationAngle text box
            {
                MessageBox.Show("Please enter a valid number (e.g. 30).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        #endregion

        #region RESET

        // This method resets the form and sets random values for the polygon
        private void btnReset_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            // Create a random center point within valid range (with random constracter)
            Point2D center = new Point2D(true);

            // Display the random center coordinates in the text boxes
            txtCenterX.Text = center.X.ToString();
            txtCenterY.Text = center.Y.ToString();

            // Also we can do it with directly (but using constarcters because it is more reusable, readable, and aligns with OOP principles (like encapsulation and single responsibility).)
            //txtCenterX.Text = rnd.Next(0, 4).ToString();
            //txtCenterY.Text = rnd.Next(0, 4).ToString();

            // Random edge length and number of edges
            txtLength.Text = rnd.Next(3, 10).ToString(); // Generate a random edge length between 3 and 9 and display it
            txtNumberOfEdges.Text = rnd.Next(3, 11).ToString();// Generate a random number of edges between 3 and 10 and display it
            txtRotationAngle.Text = "30";// Set the default rotation angle to 30 degrees

            totalRotationAngle = 0; // Reset total rotation
            labelTotalRotation.Text = $"Total Rotation Angle: {totalRotationAngle}°";


            // Generate random color and update sliders with using the constructor that supports randomness
            ColorRGB randomColor = new ColorRGB(true);
            trackBarRed.Value = randomColor.Red;
            trackBarGreen.Value = randomColor.Green;
            trackBarBlue.Value = randomColor.Blue;


            /* Also, we could generate random color values directly: (but using constarcters because it is more reusable, readable, and aligns with OOP principles (like encapsulation and single responsibility)
              trackBarRed.Value = rnd.Next(0, 256);
              trackBarGreen.Value = rnd.Next(0, 256);
              trackBarBlue.Value = rnd.Next(0, 256);

              */

            // Automatically trigger the Draw button logic to draw the polygon with the new random values
            btnDraw_Click(sender, e);
        }
        #endregion

        #endregion


        #region Drawings Methods
        /// <summary>
        /// Contains all drawing-related methods for rendering the polygon and coordinate axes
        ///  ConvertToGuiCoords: Translates mathematical coordinates to GUI screen coordinates.
        ///  DrawAxis: Draws X and Y axes in the middle of the PictureBox for reference.
        ///  DrawPolygon: Renders the current polygon with optional fill and color settings.
        ///  DisplayVertices: Lists the (x, y) coordinates of each polygon vertex in the ListBox.
        /// These methods improve visualization and user interaction with the polygon on the canvas.
        /// </summary>


        #region ARRANGMENT PIXEL SCREEN AND DRAWING AXIS

        // Converts mathematical (X, Y) coordinates to GUI screen (pixel) coordinates
        private PointF ConvertToGuiCoords(Point2D point)
        {
            float guiX = (float)(pictureBox.Width / 2 + point.X * 20);   // Translate X to center and scale(each unit = 20 pixels)
            float guiY = (float)(pictureBox.Height / 2 - point.Y * 20);// Translate Y coordinate to screen center, scale it and invert (Y axis is flipped in GUI) 
            return new PointF(guiX, guiY);
        }

        private void DrawAxis(Graphics g)   // Draws X and Y axis lines on the form for the better user interface
        {

            Pen axisPen = new Pen(Color.Gray, 1);// Create a thin gray pen for drawing the axes

            // Draw horizontal X-axis line(middle of the PictureBox vertically
            g.DrawLine(axisPen, 0, pictureBox.Height / 2, pictureBox.Width, pictureBox.Height / 2);

            // Draw vertical Y-axis line(middle of the PictureBox horizontally)
            g.DrawLine(axisPen, pictureBox.Width / 2, 0, pictureBox.Width / 2, pictureBox.Height);
        }

        #endregion



        #region DRAW POLYGON

        // This method draws the current polygon on the PictureBox
        private void DrawPolygon()
        {

            if (polygon == null)// If the polygon hasn't been created yet, display a warning and exit the method
            {
                MessageBox.Show("Please draw a polygon first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);  // Create a new bitmap with the same dimensions as the PictureBox
            Graphics g = Graphics.FromImage(bmp); // Create a Graphics object from the bitmap to perform drawing operations
            g.Clear(Color.White);// Set the background color to white



            Pen pen = new Pen(polygon.Color.ToColor(), 2);// Line color
            Brush brush = new SolidBrush(polygon.Color.ToColor()); // Fill color

            // Convert each polygon vertex to GUI coordinates
            PointF[] guiPoints = new PointF[polygon.Vertices.Length];
            for (int i = 0; i < polygon.Vertices.Length; i++)
            {

                guiPoints[i] = ConvertToGuiCoords(polygon.Vertices[i]);// Converts (x, y) to (GUI-x, GUI-y)
            }


            // Draw the polygon if at least 2 points are defined
            if (guiPoints.Length > 1)
            {
                if (checkBoxFill.Checked) // If the fill checkbox is checked, fill the shape
                {
                    g.FillPolygon(brush, guiPoints); // Fill shape
                }


                g.DrawPolygon(pen, guiPoints);// Draw outline
            }


            DrawAxis(g); //draw coordinate axis
            pictureBox.Image = bmp;// Display drawing in PictureBox
        }

        #endregion

        #region DISPLAY VERTEX COORDÝNATES

        // Displays vertex coordinates of the polygon in the ListBox
        private void DisplayVertices()
        {
            listBoxVertices.Items.Clear();// Clear old values

            if (polygon == null)// If the polygon has not been created yet, show a warning and stop execution
            {
                MessageBox.Show("Please draw a polygon first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Print all vertices with labels
            for (int i = 0; i < polygon.Vertices.Length; i++)
            {
                // Add the vertex to the ListBox with a label like "V1 = (x, y)"
                // The printCoordinates() method returns a formatted string of the coordinates

                listBoxVertices.Items.Add("V" + (i + 1) + " = " + polygon.Vertices[i].printCoordinates());


            }
        }

        #endregion

        #endregion

    }
}
