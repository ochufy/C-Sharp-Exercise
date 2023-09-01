using System;

namespace CSExercise
{
    internal class q9
    {
        public static void Main9(string[] args)
        {
            Console.Write("Enter the first number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int n3 = int.Parse(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            int n4 = int.Parse(Console.ReadLine());

            float avg = (float)(n1 + n2 + n3 + n4) / 4;

            Console.WriteLine($"The average of {n1} , {n2} , {n3} , {n4} is: {avg}");

        }
    }
}
