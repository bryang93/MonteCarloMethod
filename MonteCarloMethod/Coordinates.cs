using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MonteCarloMethod
{
   struct Coordinates
    {
        // Struct holds x, y
        public double x;
        public double y;
        // 2-Parameter constructor that takes new set of coords
        public Coordinates(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // 1-Parameter constructor that takes Random object & initialize x, y
        public Coordinates(Random random)
        {
            this.x = random.NextDouble();
            this.y = random.NextDouble();
        }

        // hypotenuse function
        public double Function(double x, double y)
        {
            this.x = x;
            this.y = y;
            double hypotenuse = Math.Pow(x, 2) + Math.Pow(y, 2);
            return Math.Sqrt(hypotenuse);
        }
    }

}
