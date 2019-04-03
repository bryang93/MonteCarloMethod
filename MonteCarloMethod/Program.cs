using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MonteCarloMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinates Coords = new Coordinates(0, 0);
            Random random = new Random();
            Coordinates xyPairs = new Coordinates(random);

            Console.WriteLine("Welcome to the Monte Carlo method\n");
            Console.WriteLine("Select number amount to pass:");

            // prompts amount of iterations & assigns variable
            int amount = int.Parse(Console.ReadLine());
            Console.Clear();

            // counter
            int counter = 0;
            Console.WriteLine($"Overlap Amount:{counter}");
            // array containing random coords
            for (int i = 1; i <= amount; i++)
            {
                // gives value to x & y
                double hypotenuse = (xyPairs.Function(xyPairs.x, xyPairs.y));
            }

            // 2D array stores value
            double[] coordPair = new double[] { hypotenuse };
            foreach (double xy in coordPair)
            {
                Console.WriteLine(hypotenuse);
            }




        }
    }
}