using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {//kiirni hány szám van 1 és 100 között ami osztható 3-mal: 33
            int minValue = 1;
            int maxValue = 100;
            
            var count = 0;
            for (int i = minValue; i <= maxValue; i++)
            {
                if (i % 3 == 0)
                { count++; }
            }   
                Console.WriteLine("There are (0) divisible by 3 between 1 and 100: "+count);
              
                
            


        }
    }
}
