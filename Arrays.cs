using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Hash
{
    class Arrays
    {
        public static void Arrayy()
        {
            //empty array
            string[] cars;

            //string array
            string[] alphabets = { "a", "b", "c", "d", "e" };

            //numeric array
            int[] num = { 1, 2, 3, 4, 5 };

            //access the elements
            Console.WriteLine(alphabets[2]);

            //change an element
            alphabets[2] = "f";

            //array length
            Console.WriteLine(alphabets.Length);

            //loop through an array
            for (int i = 0; i < alphabets.Length; i++)
            {
                Console.WriteLine(alphabets[i]);
            }

            //foreach loop
            foreach (String s in alphabets)
            {
                Console.WriteLine(s);
            }

            //sort arrays (string)
            Array.Sort(alphabets);
            foreach (String i in alphabets)
            {
                Console.WriteLine(i);
            }

            //sort arrays (int)
            int[] numbers = { 4, 5, 2, 3, 7, 8, 9 };
            Array.Sort(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //methods like min , max , sum
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
        }
    }
}
