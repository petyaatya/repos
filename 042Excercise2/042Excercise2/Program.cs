using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroOne = 0;
            int numeroTwo = 0;

            Console.WriteLine("Please type two numbers!");
            try
            {
            numeroOne = Convert.ToInt32(Console.ReadLine());
            numeroTwo = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Idiot! This is not a number");
            }
            Console.WriteLine(numeroOne +" and "+ numeroTwo);
            int different = numeroOne - numeroTwo;

            if (different<0)
            {
                Console.WriteLine(numeroTwo);
            }
            else
            {
                Console.WriteLine(numeroOne);
            }

        }
    }
}
