using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_ClassArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = { 1, 2, 3 };

            Array array = vector as Array;

            for(int i= 0; i < array.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }

            Console.ReadKey();
        }
    }
}
