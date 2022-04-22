// See https://aka.ms/new-console-template for more information

using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the MadLibs Machine!");

            string? name1 = null;
            while (name1 == null)
            {
                Console.WriteLine("To begin, enter your name:");
                name1 = Console.ReadLine();
            }

            string? name2 = null;
            while (name2 == null)
            {
                Console.WriteLine("Enter your friend's name:");
                name2 = Console.ReadLine();
            }

            string? food = null;
            while (food == null)
            {
                Console.WriteLine("Enter your favorite food: (e.g. burgers, salad, chicken nuggets)");
                food = Console.ReadLine();
            }

            string? drink = null;
            while (drink == null)
            {
                Console.WriteLine("Enter your favorite drink: (e.g. coffee, tea, soda)");
                drink = Console.ReadLine();
            }

            string? color = null;
            while (color == null)
            {
                Console.WriteLine("Enter your favorite color:");
                color = Console.ReadLine();
            }

            string animal = null;
            while (animal == null)
            {
                Console.WriteLine("Enter your favorite animal: (e.g. dolphin, bear, platypus)");
                animal = Console.ReadLine();
            }

            string? dest = null;
            while (dest == null)
            {
                Console.WriteLine("Enter your favorite vacation destination: (e.g. the beach, the mountains, Disneyland)");
                dest = Console.ReadLine();
            }

            string? verb1 = null;
            while (verb1 == null)
            {
                Console.WriteLine("Enter a past-tense action verb: (e.g. walked, rode, ate)");
                verb1 = Console.ReadLine();
            }

            string? verb2 = null;
            while (verb2 == null)
            {
                Console.WriteLine("Enter a verb ending in -ing: (e.g. walking, riding, eating)");
                verb2 = Console.ReadLine();
            }

            string? actor = null;
            while (actor == null)
            {
                Console.WriteLine("Enter a title for a person performing an action, capitalized: (e.g. Walker, Rider, Eater)");
                actor = Console.ReadLine();
            }

            string? adj1 = null;
            while (adj1 == null)
            {
                Console.WriteLine("Enter an adjective, capitalized: (e.g. Sunny, Fluffy, Greasy)");
                adj1 = Console.ReadLine();
            }

            string? adj2 = null;
            while (adj2 == null)
            {
                Console.WriteLine("Enter a different adjective: (e.g. stinky, bouncy, juicy)");
                adj2 = Console.ReadLine();
            }

            string? adj3 = null;
            while (adj3 == null)
            {
                Console.WriteLine("Enter another different adjective: (e.g. spicy, ugly, steamy)");
                adj3 = Console.ReadLine();
            }

            Console.WriteLine($"It was a {adj2} day in {dest}.");
            Console.WriteLine($"{name1} was on vacation with his best friend, {name2}.");
            Console.WriteLine($"The two of them were out {verb2} {food} and {drink} at the local tavern, \"The {adj1} {actor}\".");
            Console.WriteLine($"All of a sudden, they were approached by a {adj3} {color} {animal}.");
            Console.WriteLine($"The {animal} asked, \"You got enough {food} for me?\"");
            Console.WriteLine($"{name1} replied, \"Sure! Come join us!\", and they {verb1} around for the rest of the day.");
        }
        public static int Add(params int[] list)
        {
            int sum = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                sum += list[i];
            }
            return sum;
        }
        public static int Subtract(params int[] list)
        {
            int difference = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                difference -= list[i];
            }
            return difference;
        }
        public static int Multiply(params int[] list)
        {
            int product = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                product *= list[i];
            }
            return product;
        }
        public static int Divide(params int[] list)
        {
            double quotient = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                quotient /= list[i];
            }
            return (int)Math.Round(quotient, 0); ; ;
        }
    }
}
