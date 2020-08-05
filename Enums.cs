using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Hash
{
    class Enums
    {
        enum Weeks
        {
            Sunday, //0 (by default)  is random number then sunday = 2;
            Monday, //1
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        enum alphabets : long     //string will give error
        {
            a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z
        }

        //ConstantAndEnums
        public static void Enum()
        {
            const double pi = 3.14;             //named constant
            //pi = 2.44; (will give error cannot assign it again)

            int r = 10;
            var area = pi * r * r;
            Console.WriteLine(area);


            //ENUMS (collection of constants)

            int value = (int)Weeks.Monday;
            Console.WriteLine("value of monday is:" + value);
            Console.ReadLine();
        }
    }
}
