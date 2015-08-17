using System;
namespace CSExercises
{
    public class Ex19
    {
        
        public static void Main(string[] args)
        {

            Console.WriteLine("please enter the distance travelled");
            string distance = Console.ReadLine();
            double distance1 = Convert.ToDouble(distance);
            if(distance1<0.5)
            {
               double  fare= 2.40 ;
                Console.WriteLine("the fare is "+fare);

            }
            else if(distance1<9)
            {
                double fare1 = 2.40 + (distance1 - 0.5) * 0.4;
                Console.WriteLine("the fare is " + fare1);
            }
            else
            {
                double fare2 = 2.40 + 8.5 * 0.4 + (distance1 - 9) * 0.5;
                Console.WriteLine("the fare is " + fare2);
            }
        }
    }
}