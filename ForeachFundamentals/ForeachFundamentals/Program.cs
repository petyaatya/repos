using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //var name = "Tony Soprano";
            ////for (var i = 0; i < name.Length; i++)//név karakterek száma a length
            ////{
            ////    Console.WriteLine(name[i]);
            ////}
            //foreach (var character in name)
            //{
            //    Console.WriteLine(character);
            //}
            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
