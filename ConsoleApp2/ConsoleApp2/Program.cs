using ConsoleApp2.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            var tony = new Person();
            tony.FirstName = "Tony";
            tony.LastName = "Newhill";
            tony.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(10, 2);
            System.Console.WriteLine(result);

        }
    }
}
