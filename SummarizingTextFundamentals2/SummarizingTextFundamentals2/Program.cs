using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingTextFundamentals2
{
class Program//shift+tab a formázása
{
    static void Main(string[] args)
    {
        var sentence = "This is a really really really really really very very really long text";
            var summary = StringUtility.SummerizeText(sentence,25);
            Console.WriteLine(summary);

           

    }

   

   // }
}
}
