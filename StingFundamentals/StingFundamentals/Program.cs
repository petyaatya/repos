using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StingFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Tony Soprano ";
            Console.WriteLine("Trim '{0}'",fullName.Trim());
            Console.WriteLine("ToUpper '{0}'", fullName.Trim().ToUpper());
            Console.WriteLine("ToLower '{0}'", fullName.ToLower());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("firsName "+firstName);
            Console.WriteLine("lastname "+lastName);

            var names = fullName.Split(' ');
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);

           var toniname= fullName.Replace("Tony", "Toni");
            var oname = fullName.Replace("o", "O");
           var underlineName= fullName.Replace(" ", "_");
          

            Console.WriteLine(toniname);
            Console.WriteLine(oname);
            Console.WriteLine(underlineName);
            Console.WriteLine(fullName.Replace(" ", ""));

            if (String.IsNullOrEmpty(null))
                Console.WriteLine("invalid");

            if (String.IsNullOrEmpty(" "))//nem ad invalidot technikailag
                Console.WriteLine("invalid");

            if (String.IsNullOrEmpty(" ".Trim()))//ez igy rusnya
                Console.WriteLine("invalid");
            if (String.IsNullOrWhiteSpace(" "))//többet nem kell trim mer a ms bevezette az isnullorwhitspace metódust
                Console.WriteLine("invalid");

            //átváltani stringet intre és vissza
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);
            
            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));//kerekit

        }
    }
}
