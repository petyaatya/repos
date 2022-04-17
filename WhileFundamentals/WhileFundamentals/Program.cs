using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (var i = 1; i <=10; i++)
            //{
            //    if (i%2==0)
            //    Console.WriteLine(i);

            //}


            //var i = 0;//while loop
            //while (i<=10)
            //{
            //    if (i%2==0)
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //    }
            //}

            //while (true) //addig kéri a nevet amíg nem üres vagy space amit beütsz.
            //{
            //    Console.Write("Type your name: ");
            //   var input = Console.ReadLine();

            //    if (String.IsNullOrWhiteSpace(input))
            //        break;

            //    Console.WriteLine("@Echo: "+input);

            //}
            while (true) //addig kéri a nevet amíg nem üres vagy space amit beütsz.
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                  
                { 
                Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;

            }
        }
    }
}
