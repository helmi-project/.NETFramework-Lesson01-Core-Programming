using System;

namespace if_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            if (number2 > number1)
                Console.WriteLine("number2 is greater than number1");

            if (number1 > 5)
            {
                Console.WriteLine("number1 is greater than 5");
                if (number1 < 20)
                {
                    Console.WriteLine("number1 is less than 20");
                }
            }
        }
    }
}
