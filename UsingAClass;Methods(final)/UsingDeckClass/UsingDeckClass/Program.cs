using System;

namespace UsingDeckClass
{
    /// <summary>
    /// Classes and Objects lecture code
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates using a Deck class
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // declare and print a deck of cards
            Deck deck = new Deck();
            deck.Print();

            // access and print Empty property
            //bool isEmpty = deck.Empty;
            //Console.WriteLine("Deck empty: " + isEmpty);
            //Console.WriteLine("Deck empty: " + deck.Empty);

            // shuffle and print deck
            //Console.WriteLine();
            //deck.Shuffle();
            //deck.Print();

            // cut and print deck
            //Console.WriteLine();
            //deck.Cut(26);
            //deck.Print();

            // take and print the top card from the deck
            Console.WriteLine();
            deck.TakeTopCard();
            Card card = deck.TakeTopCard();
            Console.WriteLine(card.Rank + " of " + card.Suit);
        }
    }
}
