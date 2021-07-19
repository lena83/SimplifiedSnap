using System;
using System.Collections.Generic;
using SimplifiedSnap.Model;

namespace SimplifiedSnap.Services
{
    public class DeckManager
    {
      
        private Deck[] _decks;

        public DeckManager()
        {
            
        }

        public Deck[] Decks
        {
            get
            {
                return _decks;
            }
            set
            {
                _decks = value;
                AggregateCardsFromAllDecks();
            }
        }

        public List<Card> AllCards { get; private set; }

        private void AggregateCardsFromAllDecks()
        {
            AllCards = new List<Card>();
            foreach (Deck deck in _decks)
            {
                AllCards.AddRange(deck.Cards);
            }
        }
        

        
    }
}
