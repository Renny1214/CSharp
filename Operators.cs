using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Hash
{
    class Operators
    {
        public static void operatorr()
        {
            //Arithmetic Operator  (Binary)
            int result;
            int a = 10, b = 5;
            result = a + b;  //add
            Console.WriteLine(result);
            result = a * b;  //multiplication
            Console.WriteLine(result);
            result = a - b;   //subtraction
            Console.WriteLine(result);
            result = a / b;  //division
            Console.WriteLine(result);
            result = a % b;  //modulo
            Console.WriteLine(result);

            //Arithmetic Operator (Uniary)
            int c = 10;
            int res;

            res = c++;
            Console.WriteLine("c", c);
            Console.WriteLine("res", res);
            res = c--;
            Console.WriteLine("c", c);
            Console.WriteLine("res", res);
            res = ++c;
            Console.WriteLine("c", c);
            Console.WriteLine("res", res);
            res = --c;
            Console.WriteLine("c", c);
            Console.WriteLine("res", res);



            //Relational Operators
            int d = 5;
            int e = 10;
            bool result1;

            result1 = (d == e);
            Console.WriteLine("Equal to Operator: " + result1);
            result1 = (d > e);
            Console.WriteLine("Greater than Operator: " + result1);
            result1 = (d < e);
            Console.WriteLine("Less than Operator: " + result1);
            result1 = (d >= e);
            Console.WriteLine("Greater than or Equal to: " + result1);
            result1 = (d <= e);
            Console.WriteLine("Lesser than or Equal to: " + result1);
            result1 = (d != e);
            Console.WriteLine("Not Equal to Operator: " + result1);

        }
    }
}
