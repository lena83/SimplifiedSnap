using System;
using NUnit.Framework;
using SimplifiedSnap.Model;
using SimplifiedSnap.Services;

namespace SimplifiedSnap.Tests
{
    [TestFixture]
    public class DeckManagerTests
    {
         private DeckManager _deckManagerObject;
         private DeckFactory _deckFactory;
         private int NumberOfDecks = 1;

        public DeckManagerTests()
        {
            _deckFactory = new DeckFactory();
            _deckManagerObject = new DeckManager();
        }

        [Test]
        public void CanCreateOneDeck()
        {
            var decks = _deckFactory.CreateDecks(1);
            Assert.AreEqual(decks.Length, 1);
        }

        [Test]
        public void CanCreateNDecks()
        {
            var n = 50;
            var decks = _deckFactory.CreateDecks(n);
            Assert.AreEqual(decks.Length, n);
        }

        [Test]
        public void CheckNumberOfAggregatedCardsInAllDecks()
        {
            var n = 50;
            var numberOfExpectedCards = 2600;
            var decks = _deckFactory.CreateDecks(n);
            _deckManagerObject.Decks = decks;
            var cards = _deckManagerObject.AllCards;

            Assert.AreEqual(cards.Count, numberOfExpectedCards);
        }

       
    }

   
}
