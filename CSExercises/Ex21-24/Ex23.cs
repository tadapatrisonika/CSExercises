using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {

           /* int snum = 4;*/
            Random r = new Random();
            int snum = r.Next(1, 11);
            int cnt = 0;
            Console.WriteLine("guess the NUM on mind : ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != snum)
            {
                cnt = cnt + 1;
                Console.WriteLine("please try again");
                Console.WriteLine("guess the NUM on mind : ");
                 num = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("CONGRATS..You have guessed the number");
            Console.WriteLine("you took " + cnt + "attempts to guess the number");

        }
    }
}
