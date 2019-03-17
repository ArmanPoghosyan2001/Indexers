using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Covariant
{
    interface IAnimal
    {
        void Voice();
    }

    public class Dog: IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Voice");
        }

        public void Jump()
        {
            Console.WriteLine("Jump");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = { new Dog(), new Dog(), new Dog() };

            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Voice();
                dogs[i].Jump();
            }

            Console.WriteLine(new string('-',10));

            IAnimal[] animal = dogs;

            for (int i = 0; i < dogs.Length; i++)
            {
                animal[i].Voice();
            }

            Console.WriteLine(new string('-',10));

            dogs = (Dog[])animal;

            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Voice();
                dogs[i].Jump();
            }

            Console.ReadKey();

        }
    }
}
