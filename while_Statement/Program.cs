﻿using System;

namespace while_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("The value of i = {0}", i);
                i++;
            }
        }
    }
}
