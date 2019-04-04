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
            Random random = new Random();

            Console.WriteLine("Welcome to the Monte Carlo method\n");
            Console.WriteLine("Select number amount to pass:");

            // prompts amount of iterations & assigns variable
            int amount = int.Parse(Console.ReadLine());
            Console.Clear();

            // array taking 1 parameter int
            Coordinates[] coordinates = new Coordinates[amount];

            // overlap and iteration counter
            int overlap = 0;

            for (int i = 0; i < amount; i++)
            {
                coordinates[i] = new Coordinates(random);
                double hypotenus = coordinates[i].Hypotenuse();
                if (hypotenus <= 1)
                {
                    overlap++;
                }
            }
            double pointAverage = (overlap / (double)coordinates.Length) * 4;
            double difference = Math.Abs(Math.PI - pointAverage);

            Console.WriteLine($"Number of Iterations: {amount}");
            Console.WriteLine($"Pi Generated: {pointAverage}");
            Console.WriteLine($"Actual Pi = {Math.PI:F4} Difference = {difference}");
        }
    }
}