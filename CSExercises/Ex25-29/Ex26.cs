using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double i;
            Console.WriteLine("NO\tINVERSE\t\tSQUAREROOT\t\tSQUARE");
            Console.WriteLine("----------------------------------------------------------------------");
            for(i=1.0;i<=10;i++)
            {
                double inverse = 1 / i;
                double sqroot = Math.Sqrt(i);
                double square = i * i;
                Console.Write("{0:0.0}\t{1:0.000}\t\t{2:0.000}\t\t{3:0.000}",i,inverse,sqroot,square);
                Console.WriteLine();

            }
            
        }
    }
}
