using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysMatrixsFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 4, 7, 6, 8, 14, 9 };

            //length:
            Console.WriteLine("lenght"+numbers.Length);
            //indexof
            var index = Array.IndexOf(numbers, 9);
                Console.WriteLine("indexof"+index);
            //clear első kettő értékét törli és 0 lesz
            Array.Clear(numbers,0,2);
            Console.WriteLine("effect of clear");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            //copy első 3at másolja át
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("effect of copy");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }
            //sort
            Array.Sort(numbers);
            Console.WriteLine("effect of sort: ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            //reverse
            Array.Reverse(numbers);
            Console.WriteLine("effect of reverse: ");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
