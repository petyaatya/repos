using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48Excercise3
{
    class Program//faktoriális
    {
        static void Main(string[] args)
        {
            var factory =1;
            
            Console.WriteLine("Kérek egy számot: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                factory *= i;
            }
        Console.WriteLine(factory);
        }
    }
}
