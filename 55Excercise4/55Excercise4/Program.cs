using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55Excercise4
{
    class Program
    {
        //4- Write a program and ask the user to continuously enter a number
        //or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.
        static void Main(string[] args)
        {
            var numbers = new List<int>();
           
            while (true)
            {

                Console.WriteLine("szamot");
                var input = Console.ReadLine();
                if (input.ToLower() =="quit")
                {
                    break;
                }
              numbers.Add(Convert.ToInt32(input));

            }
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
            }
            Console.WriteLine("Unique numbers: ");
            foreach (var number in uniques)
            {
                Console.WriteLine(number);
            }
        }
    }
}
