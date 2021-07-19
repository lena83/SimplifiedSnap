using System;
using System.Collections.Generic;
using System.Linq;
using SimplifiedSnap.Enums;

namespace SimplifiedSnap.Model
{
    public class Deck
    {
        const int  CardVolume = 52;

        private readonly List<Card> _cards = new List<Card>(CardVolume);
        List<Card> _shuffled;

        public Deck()
        {
            Initialise();
            Shuffle();
        }

        private void Initialise()
        {
            for (Suit suit = Suit.CLUB; suit <= Suit.SPADE; suit++)
            {
                for (Rank rank = Rank.ACE; rank <= Rank.KING; rank++)
                {
                    _cards.Add(new Card(rank, suit));
                }
            }
        }

        private List<Card> Shuffle()
        {
            _shuffled = _cards.OrderBy(x => Guid.NewGuid()).ToList();
            return _shuffled;
        }

        public List<Card> Cards
        {
            get
            {
                return _shuffled;
            }
            
        }
    }
}
