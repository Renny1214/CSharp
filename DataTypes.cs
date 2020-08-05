using System;

namespace C_Hash
{
    internal class DataTypes
    {
        public static void DataType()
        {
            // data types and variables

            int number = 1234885;
            string test = number.ToString();

            //int num = "abc"; gives an error

            long bigNumber = 12334567222222226;
            int size = sizeof(int);
            int minValue = int.MinValue;
            int maxValue = int.MaxValue;


            decimal decimalNumber = 1.2233M;
            float floatNumber = 1.22F;

            char charVlaue = 'T';

            string stringVlaue = "abc";



            //Boxing and Unboxing

            int value = 1000;
            Object objValue = value;   //Boxing.. converting value to reference .. implicit conversion

            int value_convert = (int)objValue; //Unboxing ... explicit conversion


        }
    }
}