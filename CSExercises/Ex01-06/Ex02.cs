using System;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            string number = Console.ReadLine();
            int number1 = Convert.ToInt32(number);
            number1 = number1 * number1;
            Console.WriteLine("the square of the number is " + number1);
        }
    }
}
