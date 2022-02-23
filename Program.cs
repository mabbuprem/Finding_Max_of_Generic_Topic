using System;
namespace Finding_Max_Of_Generic_Topic
{
    class Program
    {
        public static void Main()
        {
            int[] arrayOfIntegers = { 4, 5, 6, 7, 8, 9 };
            float[] arrayOfFloats = { 4.6F, 7.8F, 8.8F, 9.5F };
            string[] arrayOfStrings = { "p", "m", "p", };

            //Creating object and calling with IntMax class
            IntMax<int> maxInt = new IntMax<int>(arrayOfIntegers);

            //printing max of int by calling the MaxMethod
            Console.WriteLine(maxInt.MaxMethod());

            IntMax<float> maxFloat = new IntMax<float>(arrayOfFloats);
            Console.WriteLine(maxFloat.MaxMethod());

            IntMax<string> maxString = new IntMax<string>(arrayOfStrings);
            Console.WriteLine(maxString.MaxMethod());

        }


    }


}