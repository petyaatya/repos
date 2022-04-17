using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48Excercise2
{
    class Program
    {
        static void Main(string[] args)//kérjen be számot és ha okét ütsz be akkor zárja be és adja össze a számokat
        {
          
            var sum = 0;
            while (true)
            {
                
                Console.WriteLine("számot!: ");
                var input = Console.ReadLine();
                if (input.ToLower()=="ok")
                        break;

                sum += Convert.ToInt32(input);
              
                    
            }
            Console.WriteLine("összeg:"+ sum);
        }
    }
}
