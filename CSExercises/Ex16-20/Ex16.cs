using System;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("please enter your gender M or F");
            string gender = Console.ReadLine();
            if(gender.Equals("M"))
            {
                Console.WriteLine("good morning Mr " + name);

            }
            else if(gender.Equals("F"))
            {
                Console.WriteLine("good morning Ms " + name);
            }
            else
            {
                Console.WriteLine("put in the correct input");
            }
        }

    }
}