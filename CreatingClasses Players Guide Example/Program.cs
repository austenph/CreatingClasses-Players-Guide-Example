using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses_Players_Guide_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color1 = new Color(100, 100, 100);

            Ball ball1 = new Ball(4, color1, 1);

            ball1.Throw();
        }
    }
}
