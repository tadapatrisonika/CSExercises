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
            for(i=1;i<=10;i++)
            {
                double sqroot = Math.Sqrt(i);
                double squaqre = i * i;
                Console.WriteLine("number\t\n" + i + "square root\t\n" + sqroot + "square\t\n" + squaqre);

            }
        }
    }
}
