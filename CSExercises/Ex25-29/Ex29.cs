using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            int i, count = 0;
            Console.WriteLine("enter a number");
            int N = int.Parse(Console.ReadLine());
            for (i = 1; i <= N - 1; i++)
            {
                if (N % i == 0)
                {
                    count = count + i;
                }
            }

            if (count == N)
            {
                Console.WriteLine("the number is a perfect number");
            }
            else
            {
                Console.WriteLine("the number is not a perfect number");
            }
        }
    }
}
