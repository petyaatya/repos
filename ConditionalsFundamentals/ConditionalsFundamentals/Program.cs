using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //int hour = 22;
            //if (hour <12 &&  hour >0)
            //{
            //    Console.WriteLine("morning!");
            //}
            // else if (hour >= 12 && hour < 18)
            //{
            //    Console.WriteLine("good day young sir");
            //}
            //else
            //    Console.WriteLine("goodnight left side");

            bool isGoldCustomer = true;
            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f; //ezek a sorok ugyanazok mint az alábbi:
            float price = (isGoldCustomer) ? 19.95f : 29.25f; //ha price is goldcustomer than 19.95 else 29.95
            Console.WriteLine(price);
        }
    }
}
