using System;
using SimplifiedSnap.Model;

namespace SimplifiedSnap.Services
{
    public class DeckFactory
    {
        private Deck CreateDeck()
        {
            return new Deck();
        }

        public Deck[] CreateDecks(int n)
        {
            Deck[] decks = new Deck[n];

            for (int i = 0; i < n; i++)
            {
                decks[i] = CreateDeck();
            }

            return decks;
        }
    }
}
