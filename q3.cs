using System;

namespace CSExercise
{
    internal class q3
    {
        public static void Main3(string[] args)
        {
            try
            {
                Console.Write("Enter 1st num: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd num: ");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"{n1}/{n2} = {n1 / n2}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
