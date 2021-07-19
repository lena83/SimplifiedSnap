using System;
using SimplifiedSnap.Enums;

namespace SimplifiedSnap.Model
{
   

    public class Card
    {
        private readonly Rank _rank;
        private readonly Suit _suit;
        private bool _faceUp;

    
        public Card(Rank rank, Suit suit)
        {
            _rank = rank;
            _suit = suit;
            _faceUp = false;
        }

        public bool FaceUp
        {
            get
            {
                return _faceUp;
            }
        }

        public Rank Rank
        {
            get { return _rank; }
        }

        
        public Suit Suit
        {
            get { return _suit; }
        }

        public void TurnCard()
        {
            _faceUp = !_faceUp;
        }

        public override string ToString()
        {
            if (_faceUp)
            {
                String result = "";

                switch (_rank)
                {
                    case Rank.JACK:
                        result += "Jack";
                        break;
                    case Rank.QUEEN:
                        result += "Queen";
                        break;
                    case Rank.KING:
                        result += "King";
                        break;
                    case Rank.ACE:
                        result += "Ace";
                        break;
                 
                    default:
                        result += (int)_rank;
                        break;
                }

                switch (_suit)
                {
                    case Suit.CLUB:
                        result += "Club";
                        break;
                    case Suit.SPADE:
                        result += "Spade";
                        break;
                    case Suit.HEART:
                        result += "Heart";
                        break;
                    case Suit.DIAMOND:
                        result += "Diamond";
                        break;
                    default:
                        result += "?";
                        break;
                }

                return result;
            }
            else
            {
                return "-";
            }
        }
   
}
}
