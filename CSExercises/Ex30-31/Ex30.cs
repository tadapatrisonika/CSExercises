using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int i, N;
            for (N = 5; N <= 10000; N++)
            {
                for (i = 1; i <= N; i++)
                {
                    if (N % i == 0)
                    {

                        Console.WriteLine(N);
                    }
                }
            }
        }
    }
}
