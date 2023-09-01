using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercise
{
    internal class q10
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int z = int.Parse(Console.ReadLine());

            int result1, result2;
            result1 = (x + y) * z;
            result2= (x * y) + (y * z);

            Console.WriteLine($"Result of specified numbers {x}, {y} and {z}, (x+y).z is {result1} and x.y + y.z is {result2}");
        }
    }
}
