using System;
using System.Collections.Generic;
using System.Timers;
using SimplifiedSnap.Enums;
using SimplifiedSnap.Model;

namespace SimplifiedSnap.Services
{
    public class BaseSnap
    {
        int _numberOfDecks;
        protected int _remainingCards;
        protected int _userScore;
        protected int _pcScore;
       

        DeckFactory _deckFactory;
        DeckManager _deckManager;
        private Queue<Card> _cardPile;
       
        

        public BaseSnap(DeckFactory deckFactory, DeckManager deckManager, int numberOfDecks)
        {
            _deckFactory = deckFactory;
            _deckManager = deckManager;
           
            _numberOfDecks = numberOfDecks;
           
            Init();
          
        }

        private void Init()
        {
            _userScore = 0;
            _pcScore = 0;

            var decks = _deckFactory.CreateDecks(_numberOfDecks);

            _deckManager.Decks = decks;

            CreateCardPile(_deckManager.AllCards);
        }

        private void CreateCardPile(List<Card> cards)
        {
            if (cards != null)
            {
                _cardPile = new Queue<Card>(cards);
                _remainingCards = cards.Count;
            }
        }

        protected Card DrawCard()
        {
            Card card = _cardPile.Dequeue();

            _remainingCards -= 1;
         
            card.TurnCard();

            return card;
        }


    }
}
