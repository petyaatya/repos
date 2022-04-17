using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            
            Console.WriteLine("Számot kérek 1-10-ig");
            try
            {
               numero = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("nem szám");
                
            }

            Console.WriteLine(numero);
            if (numero <= 10 && numero > 0)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
