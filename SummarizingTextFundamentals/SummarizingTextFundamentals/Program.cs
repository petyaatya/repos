using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingTextFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is a really really really really really very very really long text";
            const int maxLength = 20;
            if (sentence.Length<maxLength)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                //sentence.Substring(0, maxLength);
                var words = sentence.Split(' ');
                var totalChar = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalChar += word.Length + 1;
                    if (totalChar > maxLength) break;
                }
                var summary = String.Join(" ", summaryWords) + "...";
                Console.WriteLine(summary);

                //nem vágtuk le 
               
            }
        }
        
    }
}
