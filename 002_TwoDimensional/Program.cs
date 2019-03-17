﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_TwoDimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] array = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = random.Next(0, 10);
                }

            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("{0} ",array[i, j]);
                }
                Console.WriteLine("\n");
            }


            Console.ReadKey();

        }
    }
}
