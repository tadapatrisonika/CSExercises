using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("enter the number A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number B");
            int B = Convert.ToInt32(Console.ReadLine());
            int x = A;
            int y = B;

            while (A != B)
            {
                if (A > B)
                {
                    A = A - B;

                }
                else
                {
                    B = B - A;

                }
                int  HCF = B;
                Console.WriteLine("HCF is : " + HCF);
                int LCM = x * y / A;
                Console.WriteLine("LCM is : " + LCM);


            }
        }
    }
}
