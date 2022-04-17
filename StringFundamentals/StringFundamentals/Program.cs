using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            var firstName = "Tony";
            String lastName = "Montana";
            var myName = "Tonny";

            Int32 i;
            int j;

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is : {0}{1}", firstName, lastName);
            var names = new string[3] { "Tom", "Jerry", "Thomas" };

            var formattedName = string.Join(",",names);
            Console.WriteLine(formattedName);

            //var text = "Hello Tony\nI hope you are well\nplease check my folders:\nfolder1\tlocalhost";
            var text = @"Hello Tony
I hope you are well
please check my folders:
folder1
localhost";


            Console.WriteLine(text);
        }
    }
}
