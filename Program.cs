using System;

namespace variables
{
    internal class Program
    {
        private const string V = "M";

        static void Main(string[] args)
        {
            string name = "Macie";
            int age = 19;
            char myInitial = 'M';
            bool lovesMovies = true;
            double dogsAge = 12.5;
            decimal catAge = 2;

            Console.WriteLine($"Hello! My name is {name}.");
            Console.WriteLine($"Cool! How old are you? I am {age}.");
            Console.WriteLine($"I have a necklace that has an {myInitial} on it for 'Macie'!");
            Console.WriteLine($"Do you have a pet? I have a cat and a dog. Zoey, my dog, is {dogsAge}. Oscar, my cat, is {catAge}.");
            Console.WriteLine($"It is very {lovesMovies} that I love movies!");







        }
    }
}
