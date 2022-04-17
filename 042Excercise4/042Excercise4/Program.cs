using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042Excercise4
{
    class Program
    {
        public static int speedLimit = 90;
        static void Main(string[] args)
        {
            int carSpeed = 0;
            
            Console.WriteLine("How fast the car at the moment? [KM/H]");
            try
            {
               carSpeed= Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("not a number");
            }
            if (carSpeed<speedLimit)
            {
                Console.WriteLine("ok");
            }
            else
            {
               
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints>12)
                {
                    Console.WriteLine("driving license has been suspended");
                }
                else
                {
                    Console.WriteLine("Demerit Points:" + demeritPoints);
                }
            }


        }
    }
}
