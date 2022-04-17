using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48Excercise5
{
    class Program
    {
        static void Main(string[] args)//comma separated numbers and showing the max
        {
            Console.WriteLine("can i have comma separeted numbers? : ");
            var input = Console.ReadLine();
            var numbers =input.Split(',');
            //int[] tomb = new int[] { 2, 5, 6, 78, 42 };
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine(max);

        }
    }
}
