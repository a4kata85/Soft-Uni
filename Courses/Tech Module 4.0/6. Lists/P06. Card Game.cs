using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._CardsGame
{
    class StartUp
    {
        static void Main()
        {
            List<int> firstPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstPlayerCards.Count != 0 && secondPlayerCards.Count != 0)
            {
                
                int firstPlayerCard = firstPlayerCards[0];
                int secondPlayerCard = secondPlayerCards[0];
                if (firstPlayerCard > secondPlayerCard)
                {
                    RemoveCards(firstPlayerCards, secondPlayerCards);
                    firstPlayerCards.Add(firstPlayerCard);
                    firstPlayerCards.Add(secondPlayerCard);
                }
                else if (secondPlayerCard > firstPlayerCard)
                {
                    RemoveCards(firstPlayerCards, secondPlayerCards);
                    secondPlayerCards.Add(secondPlayerCard);
                    secondPlayerCards.Add(firstPlayerCard);
                }
                else
                {
                    RemoveCards(firstPlayerCards, secondPlayerCards);
                }
            }

            if (firstPlayerCards.Count > 0)
            {
                int sum = firstPlayerCards.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int suma = secondPlayerCards.Sum();
                Console.WriteLine($"Second player wins! Sum: {suma}"); 
            }
        }

        private static void RemoveCards(List<int> firstPlayerCards, List<int> secondPlayerCards)
        {
            firstPlayerCards.RemoveAt(0);
            secondPlayerCards.RemoveAt(0);
        }
    }
}
