using System;

namespace for_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            ForTest();

            //Contoh infinite loop untuk for loop
            /*
            for (; ;)
            {
                //do nothing
            }
            */
        }
        private static void ForTest()
        {
            for (int i = 1; i <= 5; i++) //setelah kode diuji (i <= 5), statement di dalam body dijalankan, kemudian di-increment
            {
                Console.WriteLine("The value of i = {0}", i);
            }
        }
    }
}
