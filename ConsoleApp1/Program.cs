using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("**** Foreach ******");
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

            foreach (string araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
