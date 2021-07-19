using System;
using System.Timers;

namespace SimplifiedSnap.Services
{
    public class RateSnapVariation : BaseSnap, ISnapVariation
    {

        private Timer _snapTimer;

        private bool prevDrawFinished = false;
        private bool _pcLastSnapped = false;

        public RateSnapVariation(DeckFactory deckFactory, DeckManager deckManager, int numberOfDecks) :
            base(deckFactory, deckManager, numberOfDecks)
        {
            _snapTimer = new Timer
            {
                AutoReset = true,
                Interval = 5000
            };

            _snapTimer.Elapsed += _snapTimer_Elapsed;
        }

        private void _snapTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (!prevDrawFinished)
            {
                _pcScore++;
                _pcLastSnapped = true;
            }

            _snapTimer.Stop();

        }

        public void Play()
        {
            while (Console.KeyAvailable || _remainingCards > 0)
            {
                var input = Console.ReadKey();

                if (input.Key == ConsoleKey.D)
                {
                    Console.WriteLine("\r PC draws a card...");
                    var pcCard = DrawCard();
                    Console.WriteLine(pcCard);

                    Console.WriteLine("\r User draws a card...");
                    var userCard = DrawCard();
                    Console.WriteLine(userCard);

                    if (userCard.Rank == pcCard.Rank)
                    {
                        _snapTimer.Start();
                    }
                }

                if (input.Key == ConsoleKey.Q)
                {
                    Console.WriteLine("\r Exiting game..");
                    Console.WriteLine($"Computer Score {_pcScore}");
                    Console.WriteLine($"Computer Score {_userScore}");
                    return;
                }

                if (input.Key == ConsoleKey.S)
                {
                    if (!_pcLastSnapped)
                    {
                        Console.WriteLine("Well Done! it is a snap");
                        Console.WriteLine("You are getting 1 score");
                        _userScore++;
                        prevDrawFinished = true;
                        _pcLastSnapped = false;
                    }
                    else
                    {
                        Console.WriteLine("You were late! Try to be faster next time");

                    }

                }
            }

            if (_remainingCards == 0)
            {
                Console.WriteLine($"Computer Score {_pcScore}");
                Console.WriteLine($"User Score {_userScore}");
            }


        }
    }
}
