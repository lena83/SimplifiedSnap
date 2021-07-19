using System;
using System.Collections.Generic;

namespace SimplifiedSnap.Model
{
    public class CardPile
    {
        private Queue<Card> _cardPile;
        private int _remainingCards;

        public CardPile(List<Card> shuffledCards)
        {
            if (shuffledCards != null)
            {
                _cardPile = new Queue<Card>(shuffledCards);
                _remainingCards = shuffledCards.Count;
            }
            else
            {
                throw new Exception("Cards are not available. Please take cards from the deck");
            }
        }

        public Card DrawCard()
        {
            _remainingCards--;
            Card card = _cardPile.Dequeue();
            card.TurnCard();
            return card;
        }

       // public void ReturnToPile(Card card1, Card card2)
      //  {
        //    _cardPile.Enqueue(card1);
        //    _cardPile.Enqueue(card2);

       //     _remainingCards += 2;
      //      _score++;
     //   }

        private int RemainingCards
        {
            get
            {
                return _remainingCards;
            }
        }

       // public int Score
      //  {
        //    get
       //     {
        //        return _score;
        //    }
       // }

    }
}
