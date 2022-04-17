using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48Excercise4
{
    class Program
    {
        static void Main(string[] args) //random szám 1-10 között, ki kell találnod melyik. 4 lehetőség van.
        {
            int guess;
            var random = new Random().Next(1,10);
           
            //Console.WriteLine(random);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess the random number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == random)
                {
                    Console.WriteLine("good");
                    return;
                }
            }

                Console.WriteLine("Than you are lost!");
                return;
            }
        }
               
              
            }
            

        
    