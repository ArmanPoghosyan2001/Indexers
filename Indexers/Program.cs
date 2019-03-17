using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            array = new int[5];

            array = new int[5] { 1, 2, 3, 4, 5 };

            array = new int[] { 1, 2, 3, 4, 5 };


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            Console.ReadKey();
        }
    }
}
