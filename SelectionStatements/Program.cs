using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var favNumber = 17;
            Console.WriteLine("Guess my favorite number");
            var userGuess = int.Parse(Console.ReadLine());

            if (userGuess > 17)
            {
                Console.WriteLine("Too high");
            }
            else if (userGuess < 17)
            {
                Console.WriteLine("Too low");
            }
            else
            {
                Console.WriteLine("Nevermind");

                Console.WriteLine("What is your favorite subject in school?");
                var subject = Console.ReadLine();
                switch (subject)
                {
                    case "math":
                        Console.WriteLine("Math is hard, but can be fun and useful for problem solving.");
                        break;

                    case "science":
                        Console.WriteLine("Science can tell us about the world we live in.");
                        break;

                    case "history":
                        Console.WriteLine("History tells us about our past.");
                        break;

                    case "English":
                        Console.WriteLine("English can help us broaden our vocabulary and creativity.");
                        break;

                    case "social studies":
                        Console.WriteLine("Social studies helps us to understand our society.");
                        break;

                    default
                            :
                        Console.WriteLine("Very interesting. Don't know that one. Next!");
                        break;
                }
            }
        }
    }
}
