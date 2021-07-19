using System;
using System.Timers;

namespace SimplifiedSnap.Services
{
    public class SuitSnapVariation : BaseSnap, ISnapVariation
    {
        public SuitSnapVariation(DeckFactory deckFactory, DeckManager deckManager, int numberOfDecks) :
            base(deckFactory, deckManager, numberOfDecks)
        {
            
        }

        public void Play()
        {

        }
    }
}
