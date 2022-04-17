using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const float pi = 3.14f;
            var nagyszam = 2.5f;
            var nevem = "Tony Newhill";
            var nevmas = 'a';
            string foglalkozasa = "király";
            Console.WriteLine("{0} {1}" , byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}" , int.MinValue, int.MaxValue);
            Console.WriteLine("{0} {1}" , float.MinValue, float.MaxValue);
            Console.WriteLine("{0} {1}" , decimal.MinValue, decimal.MaxValue);
            Console.WriteLine("{0}" , nevem);
            Console.WriteLine("{0}", nevem +" " + nevmas + " " + foglalkozasa);
            Console.WriteLine("{0} {1} {2}",nevem,nevmas,foglalkozasa); //ugyanaz mint előtte
            Console.WriteLine("{0}", nagyszam * pi);
            Console.WriteLine("{0} {1}", int.MinValue,int.MaxValue);


            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                Console.WriteLine("The number couldn't be converted to a byte");
            }
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                Console.WriteLine("The string couldn't be converted to a boolean");
            }
        
        }

    }
}
