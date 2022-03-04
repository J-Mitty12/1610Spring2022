using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = {"Toyota", "Chevy", "BMW"};
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
