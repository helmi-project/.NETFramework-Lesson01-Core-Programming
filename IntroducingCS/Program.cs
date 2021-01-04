using System;

namespace IntroducingCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello, world!");

            int number = 10;
            number = 20;

            const int i = 10;

            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers[0]);

            int x = 10;
            x++;
            ++x;
            Console.WriteLine(x);

            int y = x++; //variable y = 12(belum ditambah), variable x = 13
            Console.WriteLine(y);

            int z = ++x; //variable z = 14(sudah ditambah), variable x = 14
            Console.WriteLine(z);
            Console.WriteLine(x);
        }
    }
}
