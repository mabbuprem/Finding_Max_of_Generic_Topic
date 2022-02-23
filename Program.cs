using System;
namespace genericProblems
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the generic problems");
            Program findMax = new Program();
            Console.WriteLine($"Maximum number is {findMax.maxLength<int>(569, 478, 999)}");
            Console.WriteLine($"Maximum float number is {findMax.maxLength<float>(9.9F, 5.6F, 4.7F)}");
            Console.WriteLine($"Maximum string is {findMax.maxLength<string>("prem", "mery", "praveen")}");


        }

        private T maxLength<T>(T value1, T value2, T value3)

        {
            if (Comparer<T>.Default.Compare(value1, value2) > 0 && Comparer<T>.Default.Compare(value1, value3) > 0)
            {
                return value1;
            }
            else if (Comparer<T>.Default.Compare(value2, value1) > 0 && Comparer<T>.Default.Compare(value2, value3) > 0)
            {
                return value2;
            }
            else
            {
                return value3;
            }
        }
    }


}
