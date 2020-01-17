using System;

namespace MethodExcercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"Hi! My name is {name} and my favorite " +
                $"color is {color}.\n" +
                $"My favorite animal is a {animal} and my " +
                $"favorite band is {band}.");
        }
    }
}
