using System;
namespace SimplifiedSnap.Services
{
    public class RateSuitVariation : BaseSnap, ISnapVariation
    {
        public RateSuitVariation(DeckFactory deckFactory, DeckManager deckManager, int numberOfDecks) :
            base(deckFactory, deckManager, numberOfDecks)
        {

        }

        public void Play()
        {

        }
    }
}
