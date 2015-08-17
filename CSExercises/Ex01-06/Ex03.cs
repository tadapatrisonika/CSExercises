using System;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            string num = Console.ReadLine();
            double num1 = Convert.ToDouble(num);
            num1 = num1 * num1;
            Console.WriteLine("the square of the number is " + num1);
        }
    }
}
