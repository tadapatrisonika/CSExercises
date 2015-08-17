using System;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter your marks");
            string marks = Console.ReadLine();
            int marks1 = Convert.ToInt32(marks);
            if (marks1 <= 100 && marks1 >= 80)
            {
                Console.WriteLine("the grade you got is A");

            }
            else if(marks1 <= 79 && marks1 >= 60)
            { 
                Console.WriteLine("the grade you got is B");
            }
            else if(marks1 <= 59 && marks1 >= 40)
            {
                Console.WriteLine("the grade you got is C");
            }
            else if(marks1 <= 40 && marks1 >=0)
            {
                Console.WriteLine("the grade you got is F");
            }
            else if(marks1 <0)
            {
                Console.WriteLine("please enter the marks between 1-100");
            }
            else if (marks1 > 100)
            {
                Console.WriteLine("please enter the marks between 1-100");
            }
            else
            {
                Console.WriteLine("please enter the marks correctely");
            }
        }
    }
}