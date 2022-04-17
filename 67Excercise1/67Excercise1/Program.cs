using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67Excercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Write a program and ask the user to enter a few numbers separated by a hyphen (kötőjel).
            //Work out if the numbers are consecutive (egymástkövető). For example,
            //if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message:
            //"Consecutive"; otherwise, display "Not Consecutive".

            Console.WriteLine("Can i have a few numbers separated by a hpyen?");
            var input = Console.ReadLine();
            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }
            numbers.Sort();
            var isConsecutive = true;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i]!=numbers[i-1]+1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            var message = isConsecutive ? "Consecutive" : "not concevutive";
            Console.WriteLine(message);

        }
    }
}
