using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MonteCarloMethod
{
    public struct Coordinates
    {

        // Struct holds x, y
        public double x { get; set; }
        public double y { get; set; }

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

        // hypotenuse
        public double Hypotenuse()
        {
            double hypotenuse = Math.Pow(this.x, 2) + Math.Pow(this.y, 2);
            hypotenuse = Math.Sqrt(hypotenuse);
            return hypotenuse;
        }


    }
}
