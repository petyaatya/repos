using System;

namespace ReferenceAndValueTypesFundamentals
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);
            var person = new Person() {Age=20};
             MakeOld(person);
            Console.WriteLine(person.Age);
    }
           
        public static void Increment(int number)
        {
            number += 10;
         
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }

}
 /* első rész tartalma. b értéke 10 marad. array2 értéke 0
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(String.Format("a: {0}, b: {1}", a,b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}",array1[0],array2[0]));
            */

         
}
