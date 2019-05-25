using System;
using System.Collections.Generic;

namespace Lection_Problem_Solving_Cards_Shuffle
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            List<string> cardsList = new List<string>();
            string[] suits = { "S", "H", "C", "D" };
            string[] faces = { "A", "J", "Q", "K" };
            for (int i = 2; i <= 10; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    cardsList.Add(i + suits[j]);                    
                }
                
            }
            for (int i = 0; i < faces.Length; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    cardsList.Add(faces[i] + suits[j]);
                }
            }

            string[] cards = cardsList.ToArray();

            PrintCards(cards);

            for (int i = 0; i < cards.Length; i++)
            {
                SingleRandomSwap(i, cards);
            }

            PrintCards(cards);
        }

        static void Swap(int index1, int index2, string[] cards)
        {
            string oldCard = cards[index1];
            cards[index1] = cards[index2];
            cards[index2] = oldCard;
        }

        static void SingleRandomSwap(int i, string[] cards)
        {
            int randPos = rnd.Next(0, cards.Length);
            Swap(i, randPos, cards);
        }

        static void PrintCards(string[] cards)
        {
            Console.WriteLine(string.Join(", ", cards));
        }


    }
}
