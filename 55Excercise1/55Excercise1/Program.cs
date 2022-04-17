using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55Excercise1
{
    class Program
    {
//        1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

//If no one likes your post, it doesn't display anything.
//If only one person likes your post, it displays: [Friend's Name] likes your post.
//If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
//If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
//Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.


        static void Main(string[] args)
        {

            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("write names until you hit enter: ");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }



            if (names.Count == 1)
                {
                    Console.WriteLine(names.ElementAt(0)+ " liked your post");
                }
                else if (names.Count == 2)
                {
                    Console.WriteLine(names.ElementAt(0)+ " and "+ names.ElementAt(1)+ " liked your post");
                }
                else if (names.Count >= 3)
                {
                    Console.WriteLine(names.ElementAt(0)+ " "+ names.ElementAt(1)+ " and other "+ Convert.ToInt32(names.Count-2) + " friends liked the post");
                }
                else Console.WriteLine("Nobody likes your post");
               

        }
    }
}
