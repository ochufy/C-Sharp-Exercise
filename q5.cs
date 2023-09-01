using System;

namespace CSExercise
{
    internal class q5
    {
        public static void Main5(string[] args)
        {
            Console.Write("Input the First Number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number: ");
            int n2 = int.Parse(Console.ReadLine());

            int temp = n1;
            n1 = n2;
            n2 = temp;

            Console.WriteLine("After Swapping :");
            Console.WriteLine("First Number: " + n1);
            Console.WriteLine("Second Number: " + n2);
        }
    }
}
