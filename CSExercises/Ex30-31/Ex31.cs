using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("the perfect number:");
            int N, i;
            for (N = 1; N <= 1000; N++)
            {
                int count = 0;
                for (i = 1; i <=( N/2) ; i++)
                {
                    if (N % i == 0)
                    
                        count = count + i;
                    }
                
                if (count == N)
                {
                    Console.WriteLine("{0}",N);
                }
            }

            }

        }
    }

