using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67Excercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
            //A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok";
            //otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

            Console.WriteLine("enter the time: ");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) {
                Console.WriteLine("invalid time");
                return; }
            var components = input.Split(':');
            if (components.Length!=2)
            {
                Console.WriteLine("invalid time");
                return;
            }
            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("ok");
                else Console.WriteLine("invalid time");
                        
            }
            catch (Exception)
            {

                Console.WriteLine("invalidtime");
            }
        }
    }
}
