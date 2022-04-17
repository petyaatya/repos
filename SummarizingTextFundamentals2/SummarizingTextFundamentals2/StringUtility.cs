using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingTextFundamentals2
{
   public class StringUtility
    {
        public static string SummerizeText(string text, int maxLength = 20) //amig nem volt public addig a mainba a stringutiliy üres volt
        {
            //const int maxLength = 20; //beirtuk paraméterként a metódusba egy sorral feljebb
            if (text.Length < maxLength) //sentence átirva textre
            {
                return text; //cw átirva itt meg alul és már nem is hibás a summerizetext metódusnév
            }
            //else //else felesleges mer tudjuk h hosszabb mint a maxlenght tehát úgyis ez a részlet fut le
            //{
            //sentence.Substring(0, maxLength);
            var words = text.Split(' ');
            var totalChar = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalChar += word.Length + 1;
                if (totalChar > maxLength) break;
            }
            return String.Join(" ", summaryWords) + "...";




        }
    }
}
