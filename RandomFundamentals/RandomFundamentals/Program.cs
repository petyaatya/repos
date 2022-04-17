using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //var random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    //Console.WriteLine((char)random.Next(56, 100));//ascii karaktereket fog igy kiadni a random osztály
            //    Console.Write((char)('a'+random.Next(0,26)));//egy sorba irja ki őket sortörés nélkül. random passwordnél pl jó lehet
            //}
            ////Console.WriteLine((int)'a'); //intre alakitva az A ascii karakter

            var random = new Random();

            const int passwdLength = 10;
            char[] buffer = new char[passwdLength];
            for (int i = 0; i < passwdLength; i++)
                buffer[i] = (char)('a'+random.Next(0, 26));
            var passwd = new string(buffer);
            Console.WriteLine(passwd);
        }
    }
}
