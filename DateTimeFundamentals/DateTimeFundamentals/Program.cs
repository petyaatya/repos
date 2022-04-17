using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2022, 2, 7);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);
            Console.WriteLine(now.Second);

            Console.WriteLine(today.Year);
            Console.WriteLine(today.Month);
            Console.WriteLine(today.Day);

            var tomorrow = now.AddDays(1);
            Console.WriteLine(tomorrow);

            var today1 = now.AddDays(0);
            Console.WriteLine(today1);

            var yesterday = now.AddDays(-1);
            Console.WriteLine(yesterday);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            //Creating
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            //var start = DateTime.Now(); //már deklarálva nowként
            var end = DateTime.Now.AddMinutes(3);
            var duration = end - now;
            Console.WriteLine("Duration: "+ duration);

            //Properties
            Console.WriteLine("Minutes" + timeSpan.Minutes);
            Console.WriteLine("Total minutes: "+ timeSpan.TotalMinutes);

            //add

            Console.WriteLine("Add example: "+timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));


            //ToString
            Console.WriteLine("ToString: " + timeSpan.ToString());

            //parse
            Console.WriteLine("Parse" + TimeSpan.Parse("01:02:03"));

            
            
            var dateTime2 = new DateTime(2015, 1, 1);

            dateTime2.AddYears(1);

            Console.WriteLine(dateTime2.Year);



        }
    }
}
