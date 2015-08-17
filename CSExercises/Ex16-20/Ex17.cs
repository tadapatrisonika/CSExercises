using System;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("please enetr your gender");
            string gender = Console.ReadLine();
            Console.WriteLine("please enter your age");
            string age = Console.ReadLine();
            int age1 = Convert.ToInt32(age);
            if (age1 <= 40)
            {
                if (gender.Equals("M"))
                {
                    Console.WriteLine("good morning Mr " + name);

                }
                else if (gender.Equals("F"))
                {
                    Console.WriteLine("good morning Ms " + name);
                }
                else
                {
                    Console.WriteLine("put in the correct input");
                }

            }
            else if (age1 >= 40)
            {
                if (gender.Equals("M"))
                {
                    Console.WriteLine("good morning Uncle " + name);

                }
                else if (gender.Equals("F"))
                {
                    Console.WriteLine("good morning Aunty " + name);
                }
                else
                {
                    Console.WriteLine("put in the correct input");
                }
            }
            else
            {
                Console.WriteLine("wrong input");
            }
        }
    }
}