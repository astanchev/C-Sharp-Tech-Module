using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int numberMessages = int.Parse(Console.ReadLine());

            string[] phrases =
                {"Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product."};

            string[] events =
                { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors =
                {"Diana", "Petya", "Stella", "Elena",
                "Katya", "Iva", "Annie", "Eva"};

            string[] cities = { "Burgas", "Sofia", "Plovdiv",
                                "Varna", "Ruse" };


            for (int i = 0; i < numberMessages; i++)
            {
                string phrase = phrases[rnd.Next(0, phrases.Length)];
                string @event = events[rnd.Next(0, events.Length)];
                string author = authors[rnd.Next(0, authors.Length)];
                string city = cities[rnd.Next(0, cities.Length)];
                Console.WriteLine($"{phrase} {@event} {author} – {city}.");
            }
        }
    }
}
