using System;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            string num = Console.ReadLine();
            double num1 = Convert.ToDouble(num);
            num1 = Math.Sqrt(num1);
            Console.WriteLine("the square root of the number is " + num1);
        }
    }
}
