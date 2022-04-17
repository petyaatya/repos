using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67Excercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {//5- Write a program and ask the user to enter an English word.
         //Count the number of vowels (a, e, o, u, i) in the word. So,
         //if the user enters "inadequate", the program should display 6 on the console.

            Console.WriteLine("szót: ");
            var input = Console.ReadLine().ToLower();//This is used to count for both A and a.
            
            var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
            var vovelsCount = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vovelsCount++;
            }
            Console.WriteLine(vovelsCount);
        }
    }
}
