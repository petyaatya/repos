using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrceduralProgrammingFundamentals2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("enter a number or quit to exit");
                var input = Console.ReadLine();
                if (input.ToLower()=="quit")
                    break;
                numbers.Add(Convert.ToInt32(input));


            }
            
            Console.WriteLine("Unique numbers: ");
            foreach (var number in GetUniqueNumbers(numbers))
                Console.WriteLine(number);
            //var uniques = GetUniqueNumbers(numbers); 
        }
        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);

                return uniques;
            }

        }
    }
}
