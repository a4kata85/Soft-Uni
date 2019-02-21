using System;

namespace P01.AdvertisementMessage
{
    class StartUp
    {
        static void Main()
        {
            int messages = int.Parse(Console.ReadLine());

            string[] phrases = new string[] { "Excellent product.",
                                              "Such a great product.",
                                              "I always use that product.",
                                              "Best product of its category.",
                                              "Exceptional product.",
                                              "I can’t live without this product." };

            string[] events = new string[] { "Now I feel good.",
                                             "I have succeeded with this product.",
                                             "Makes miracles. I am happy of the results!",
                                             "I cannot believe but now I feel awesome.",
                                             "Try it yourself, I am very satisfied.",
                                             "I feel great!" };

            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();

            for (int i = 0; i < messages; i++)
            {
                string phrase = phrases[random.Next(0, phrases.Length)];
                string @event = events[random.Next(0, events.Length)];
                string city = cities[random.Next(0, cities.Length)];
                string author = authors[random.Next(0, authors.Length)];

                Console.WriteLine($"{phrase} {@event} {author} – {city}.");
            }
        }                                     
    }
}
