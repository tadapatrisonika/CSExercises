using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            string num = Console.ReadLine();
            double num1 = Convert.ToDouble(num);
            num1 = Math.Sqrt(num1);
            Console.WriteLine(" {0:0.000} ",num1);
        }
    }
}
