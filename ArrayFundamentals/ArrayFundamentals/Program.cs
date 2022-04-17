using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[3];
            //shorter
            var numbers = new int[3] {1,2,3};
            //numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "Tony", "Peter", "Ngovo" };
            Console.WriteLine(names[1]);

            var firstName = "Tony";
            var lastName = "Soprano";
            var name = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(name);

            string list = string.Join(",", numbers);
            Console.WriteLine(list);
            string myName = "Peter";
            char firstChar = myName[0];
            Console.WriteLine(firstChar);


        }
    }
}
