using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Hash
{
    class Strings
    {
        public static void String()
        {
            // String and string builder
            // will give hello renny mittal creates 3 copies in memory ..immutable
            string text = "hello";
            text = text + "renny";
            text = text + "mittal";

            // Console.WriteLine("string output: " + text.ToString());
            Console.ReadLine();


            //single copy.. muttable
            StringBuilder sb = new StringBuilder();
            sb.Append("hello");
            sb.Append("renny");
            sb.Append("mittal");

            //Console.WriteLine("string Builder output: " + sb.ToString());
            Console.ReadLine();


            Stopwatch sw1 = new Stopwatch();
            String s = "";

            sw1.Start();
            for (int i = 0; i <= 10; i++)
            {
                s = s + i;
            }
            sw1.Stop();
            //Console.WriteLine("string valueeee :" + s);
            //Console.ReadLine();


            Stopwatch sw2 = new Stopwatch();
            StringBuilder sb1 = new StringBuilder();
            sw2.Start();
            for (int i = 0; i <= 10; i++)
            {
                sb1.Append(i);
            }
            sw2.Stop();
            Console.WriteLine("string valueeee :" + sb.ToString());
            Console.ReadLine();

            Console.WriteLine("time by sw1 : " + sw1.ElapsedMilliseconds);
            Console.WriteLine("time by sw12 : " + sw2.ElapsedMilliseconds);
            Console.ReadLine();

        }
    }
}
