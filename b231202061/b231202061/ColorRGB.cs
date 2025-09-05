
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
    internal class ColorRGB
    {
        // Private fields
        private int red;
        private int green;
        private int blue;

        #region proporties

        /// <summary>
        ///  // Property for each component , Validates input to ensure it's within 0–255
        /// </summary>

        public int Red
        {
            get => red;
            set => red = ValidateColorValue(value, nameof(Red));
        }

        public int Green
        {
            get => green;
            set => green = ValidateColorValue(value, nameof(Green));
        }

        public int Blue
        {
            get => blue;
            set => blue = ValidateColorValue(value, nameof(Blue));
        }

        #endregion

        #region Constructors


        // Default constructor
        // Initializes the color to black (0, 0, 0)
        public ColorRGB()
        {
            red = 0;
            green = 0;
            blue = 0;
        }


        ///  Constructor with paramaters that gets specific RGB values.
        public ColorRGB(int red, int green, int blue)
        {   // Using properties ensures that values are validated
            Red = red;
            Green = green;
            Blue = blue;
        }

        // Constructor that generates a random color
        public ColorRGB(bool random)
        {
            if (random)
            {
                Random rnd = new Random();

                do
                {// Generate random values between 0 and 255
                    this.Red = rnd.Next(0, 256);
                    this.Green = rnd.Next(0, 256);
                    this.Blue = rnd.Next(0, 256);
                } while (Red == 255 && Green == 255 && Blue == 255);// Avoid white because a white polygon would be invisible on screen
                                                                    // disabled it for better user interaction


            }
            else
            {   // If not random, set to black
                this.red = 0;
                this.green = 0;
                this.blue = 0;
            }
        }

        #endregion



        ///    <summary>
        ///   This validation is useful to limit user input, such as from a TextBox, ensuring the RGB values stay within the 0–255 range.
        ///   It also prevents invalid assignments through code, maintaining data integrity
        ///   </summary>

        // Validates whether the given color value is between 0 and 255.
        // Throws an exception if out of range.
        private int ValidateColorValue(int value, string propertyName)
        {
            if (value < 0 || value > 255)
                throw new ArgumentOutOfRangeException(propertyName, "Color value must be between 0 and 255");
            return value;
        }



        
        // Converts this RGB color to a System.Drawing.Color object
        // Useful for graphical applications (e.g., Windows Forms)
        
        public System.Drawing.Color ToColor()
        {
            return System.Drawing.Color.FromArgb(red, green, blue);
        }


    }
}
