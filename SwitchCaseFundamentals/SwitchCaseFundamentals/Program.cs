using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Spring;
            switch (season)
            {
                case Season.Spring: //ha ugyanaz a duma lenne a springnél is akkor a kódismétlés elkerülése végett ha üresen hagyjuk utána akkor is ez van
                case Season.Summer:
                    Console.WriteLine("Nyár akarom süssön a nap");
                    break;
                case Season.Autumn:
                    Console.WriteLine("itt az ősz itt van újra s szép mint mindig én nekem");
                    break;
                case Season.Winter:
                    Console.WriteLine("A naptárra nézek december 4 már csak néhány nap és a szeretet újra él");
                    break;
                default:
                    Console.WriteLine("nem vágom milyen évszak van");
                    break;
            }
        }
    }
}
