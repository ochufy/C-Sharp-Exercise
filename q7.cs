using System;

namespace CSExercise
{
    internal class q7
    {
        public static void Main7(string[] args)
        {
            try
            {
                Console.Write("Input the First Number: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Input the Second Number: ");
                int n2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
                Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
                Console.WriteLine($"{n1} x {n2} = {n1 * n2}");
                Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
                Console.WriteLine($"{n1} mod {n2} = {n1 % n2}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
