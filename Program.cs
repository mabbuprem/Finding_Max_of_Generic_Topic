using System;
namespace genericProblems
{
    class Program
    {

        public static void Main()
        {
            Console.WriteLine("Welcome to the generic problems");
            Program findMax = new Program();
            findMax.maxLength("Apple", "mango", "Banana");
        }
        private void maxLength(string value1, string value2, string value3)
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0)
            {
                Console.WriteLine(value1);
            }
            else if (value2.CompareTo(value3) > 0 && value2.CompareTo(value1) > 0)
            {
                Console.WriteLine(value2);
            }
            else
            {
                Console.WriteLine(value3);
            }
        }
    }
}
