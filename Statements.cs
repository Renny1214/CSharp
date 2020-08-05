using System;

namespace C_Hash
{
    internal class Statements
    {
        public static void Statement()
        {
            //statements

            //1.if else
            int a = 5;
            int b = 5;
            int c = 6;
            if (a == b)
            {
                Console.WriteLine("a is equal to b");
            }
            else if (b == c)
            {
                Console.WriteLine("b is equal to c");
            }
            else
            {
                Console.WriteLine("they are now equal");
            }


            //2.Switch statement
            int num = 5;
            switch (num)
            {
                case 1:
                    Console.WriteLine("this is 1");
                    break;
                case 2:
                    Console.WriteLine("this is 2");
                    break;
                case 3:
                    Console.WriteLine("this is 3");
                    break;
                default:
                    Console.WriteLine("this is more than 3");
                    break;
            }

            //for loop
            for (int i = 0; i < -5; i++)
            {
                Console.WriteLine(i);
            }

            //for each loop
            int[] array = new int[4] { 1, 2, 3, 4 };
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }

            //while 
            int count = 0;
            while (count < 3)
            {
                Console.WriteLine("hello");
                count++;
            }

            //do whilw loop
            do
            {
                Console.WriteLine("yes");
            }
            while (count < 3);

            //break statement
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            //continue statement
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //break and continue in while loop
            int d = 0;
            while (d < 10)
            {
                Console.WriteLine(d);
                d++;
                if (d == 4)
                {
                    break;
                }
            }

            int e = 0;
            while (e < 10)
            {
                if (e == 4)
                {
                    e++;
                    continue;
                }
                Console.WriteLine(e);
                e++;
            }

            //jump or goto statement
            int k = 20;
            switch (k)
            {
                case 5:
                    Console.WriteLine("5");
                    break;
                case 10:
                    Console.WriteLine("10");
                    break;
                case 20:
                    Console.WriteLine("20");
                    goto case 5;
                default:
                    Console.WriteLine("no match found");
                    break;
            }

        //or
        ineligible:
            Console.WriteLine("you are below 18");

            Console.WriteLine("Enter your age:\n");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("cast your vote");
            }
        }
    }
}