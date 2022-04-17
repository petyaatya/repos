using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67Excercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4- Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase.
            //For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program
            //is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            Console.WriteLine("Give a few words separated by space");
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("error");
                return;
            }
            var wordList = new List<string>();
            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;

            }
            Console.WriteLine(variableName);
            
        }
    }
}