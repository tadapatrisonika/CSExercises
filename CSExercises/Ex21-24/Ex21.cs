using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int num;
             Console.WriteLine("enter a number: ");
             num= Convert.ToInt32(Console.ReadLine());
 
            while ( num != 88)
            {
             Console.WriteLine("enter a number: ");
             num= Convert.ToInt32(Console.ReadLine());

            }
           
            Console.WriteLine("\"Lucky You...\"");
        }
    }
}
