using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses_Players_Guide_Example
{
    class Ball
    {
        //fields
      private double radius;
      private Color color = new Color(100, 100, 100);
      private int times_thrown;

        //properties
        public int TimesThrown
        {
            get { return this.times_thrown; }
        }

        //constructors
        public Ball ()
        {
            this.radius = 0;
            this.times_thrown = 0;
        }
        public Ball (double radius, Color color, int times_thrown)
        {
            this.radius = radius;
            this.color = color;
            this.times_thrown = times_thrown;
        }
        //methods
        public int Pop (int radius)
        {
            int size = 0;
            size = radius;
            return size;
        }

        public int Throw ()
        {
            if (radius > 0)
            {
                this.times_thrown = this.times_thrown +1;
            }
            return this.times_thrown;
        }
    }
}
