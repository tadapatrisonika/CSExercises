using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            int i, flag=0;
            Console.WriteLine("enter a number");
            int N = int.Parse(Console.ReadLine());
            for(i=2;i<=N-1;i++)
            {
                if(N % i == 0)
                {
                    flag = 1;
                }
            }
        
        if(flag == 0) 
    {
         Console.WriteLine("the number is a prime number" );
    }
                    else
                    {
                        Console.WriteLine("the number is not a prime number" );
                    }
                }
    }
}
            
        
    

