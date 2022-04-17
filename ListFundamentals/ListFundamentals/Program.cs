using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1,2,3,4,5};
            numbers.Add(1);
            numbers.AddRange(new int[3] { 2, 33, 42 }); //add another list or array
            foreach (var number in numbers)
            Console.WriteLine(number);
            Console.WriteLine("indexof 1: "+numbers.IndexOf(1));
            Console.WriteLine("last of 1: " + numbers.LastIndexOf(1));
            Console.WriteLine("count: "+ numbers.Count);

            numbers.Remove(1);
            foreach (var number in numbers)
                Console.WriteLine(number);

            for (int i = 0; i < numbers.Count; i++)
            {

                if (numbers[i] == 1)
                
                    numbers.Remove(numbers[i]);
                
            }
            
                foreach (var number in numbers)
                    Console.WriteLine(number);
            numbers.Clear();
            Console.WriteLine("count: " + numbers.Count);
        }
    }
}
