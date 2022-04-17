using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var builed = new StringBuilder();
           

            builed.Append('-', 10) //össze lehet láncolni a metódusokat így, kevesebb ismétlés, átláthatóbb.
            .AppendLine()
            .Append("Header")
            .AppendLine()
            .Append('-',10)
            .Replace('-', '+')
            .Remove(0, 10);

            builed.Insert(0, new string('-', 10));//eleje újra -------
            Console.WriteLine(builed);

            var builder = new StringBuilder("Hello World");
            Console.WriteLine(builder);
            Console.WriteLine("First charcter: "+builder[0]);
            
        }
    }
}
