using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses_Players_Guide_Example
{
    class Color
    {
        //fields   
        private int red;
        private int blue;
        private int green;
        private int alpha;

        //properties
        public int Red
        {
            get { return this.red; }
            set { this.red = value; }
        }
        public int Blue
        {
            get { return this.blue; }
            set { this.blue = value; }
        }
        public int Green
        {
            get { return this.green; }
            set { this.green = value; }
        }
        public int Alpha
        {
            get { return this.alpha; }
            set { this.alpha = value; }
        }

        //constructors
        public Color (int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
            this.alpha = alpha;
        }
        public Color (int red, int green, int blue)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
            this.alpha = 255;
        }

        //methods
        public int Grayscale (int red, int green, int blue)
        {
            int average = (red + green + blue) / 3;
            return average;
        }
    }
}
