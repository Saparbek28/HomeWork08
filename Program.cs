﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(3);
            array[0] = 4;
            array[1] = 134;
            array[2] = 3456;

            for (int i = 0; i < array.Size; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
