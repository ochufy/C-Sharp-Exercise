using System;

namespace CSExercise
{
    internal class q6
    {
        public static void Main6(string[] args)
        {
            Console.Write("Input the first number to multiply: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n1} x {n2} x {n3} = {n1 * n2 * n3}");
        }
    }
}
