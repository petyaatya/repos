using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55Excercise2
{
    //2- Write a program and ask the user to enter their name.Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nevet: ");
            var name = Console.ReadLine();
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];
            var reversed = new string(array);
            Console.WriteLine(reversed);
        }
    }
}
