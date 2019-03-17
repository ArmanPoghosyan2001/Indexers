using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_VarArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(array1.GetType());


            var array2 = new[] { 3.145, 6, 5 };
            Console.WriteLine(array2.GetType());


            Console.ReadKey();
        }
    }
}
