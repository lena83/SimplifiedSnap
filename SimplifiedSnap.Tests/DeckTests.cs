using System;
using NUnit.Framework;
using SimplifiedSnap.Model;

namespace SimplifiedSnap.Tests
{
    [TestFixture]
    public class DeckTests
    {
        Deck _deckObject = null;
        const int ConincidenceThreshold = 10;
        const int ExpectedNumberOfCardsInDeck = 52;

        public DeckTests()
        {
            _deckObject = new Deck(); 
        }

        [Test]
        public void IsDeckCreated()
        {
            Assert.IsNotNull(_deckObject);
            Assert.IsNotNull(_deckObject.Cards);
        }

        [Test]
        public void DeckContainsCorrectNumberOfCards()
        {
            Assert.AreEqual(_deckObject.Cards.Count, ExpectedNumberOfCardsInDeck);
        }

        [Test]
        public void CardsAreInRandomOrder()
        {
            Deck _newDeckObject = new Deck();
            int numberOfMatches = 0;
            
            for (int i = 0; i < ExpectedNumberOfCardsInDeck; i++)
            {
                if (_newDeckObject.Cards[i].Rank == _deckObject.Cards[i].Rank && _newDeckObject.Cards[i].Suit == _deckObject.Cards[i].Suit)
                {
                    numberOfMatches++;
                }
            }

            Assert.Less(numberOfMatches, ConincidenceThreshold);

        }

    }
}
