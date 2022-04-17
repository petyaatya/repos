using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)//hármasával lépked 1000ig fel
            {
                if (i%3==0)
                {
                    Console.WriteLine(i);
                }
            }
            for (int i = 10; i >= 1; i--) //2-esével lépked lefele 1-ig 10től
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
