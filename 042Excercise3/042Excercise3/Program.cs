using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042Excercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 0;
            int height = 0;
            Console.WriteLine("width:");
           width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("height:");
            height = Convert.ToInt32(Console.ReadLine());
            if (width>height)
            {
                Console.WriteLine("The picture is a landscape");
            }
            else
            {
                Console.WriteLine("This is a portarait");
            }
        }
    }
}
