using System;

namespace MethodExcercise_1
{
    class Program
    {
        public static int Sum(int x, int y)
        {
            int result = x + y;
            return result;
        }

        public static decimal Sum(decimal x, decimal y)
        {
            decimal sum = x + y;
            return sum;
        }

        public static int Subtract(int x, int y)
        {
            int result = x + y;
            return result;
        }

        public static int Multiply(int x, int y)
        {
            int result = x * y;
            return result;
        }

        public static int Division(int x, int y)
        {
            int result = x / y;
            return result;
        }

        public static string Add(int x, int y, bool z)
        {
            if (z == true)
            {
                int result = x + y;
                if (result == 1)
                    return $"{result} dollar";
                else
                    return $"{result} dollars";
            }
            else
                return "";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(3, 4, true));

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
