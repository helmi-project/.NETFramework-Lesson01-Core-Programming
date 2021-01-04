using System;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }
        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1; //base case | bagian yang menentukan kondisi terminasi dan tidak memanggil method kembali
            }
            else
            {
                return n * Factorial(n - 1); //recursive case | bagian yang memindahkan algoritma ke base case dan memanggil method kembali
            }

        }
    }
}
