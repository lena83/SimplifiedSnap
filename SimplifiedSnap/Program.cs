using System;
using SimplifiedSnap.Enums;
using SimplifiedSnap.Model;
using SimplifiedSnap.Services;

namespace SimplifiedSnap
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Snap Game");
            Console.WriteLine("Please enter the number of decks you would like to play with (from 1 to N)");


            string decks = Console.ReadLine();

            int deckNumber;
            bool isNumeric = int.TryParse(decks, out deckNumber);

            if (!isNumeric)
            {
                Console.WriteLine("The number of decks should be a positive number from 1 to N");
                Console.ReadKey();
                return;
            }

            if (isNumeric)
            {
                if (deckNumber <= 0 )
                {
                    Console.WriteLine("The number of decks should be a positive number from 1 to N");
                    Console.ReadKey();
                    return;
                }
            }
           
            //check if deck is int

            Console.WriteLine("Choose the snap rules");
            Console.WriteLine("The 'Snap!' matching condition can be : ");
            Console.WriteLine(" 1. The Face value of the card (Please type 1)");
            Console.WriteLine(" 2. The Suit (Please type 2)");
            Console.WriteLine(" 3. Both (Please type 3)");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string snapRule = Console.ReadLine();

            SnapConditions snapCondition = SnapConditions.UNDEFINED;

            switch (snapRule)
            {
                case "1":
                    {
                        snapCondition = SnapConditions.FACEVALUE;
                        Console.WriteLine($"You chose to play Snap! with {deckNumber} decks. The Snap rule is Face Value of the card should match");
                        break;
                    }
                case "2":
                    {
                        snapCondition = SnapConditions.SUIT;
                        Console.WriteLine($"You chose to play Snap! with {deckNumber} decks. The Snap rule is Rank of the card should match");
                        break;
                    }
                case "3":
                    {
                        snapCondition = SnapConditions.BOTH;
                        Console.WriteLine($"You chose to play Snap! with {deckNumber} decks. The Snap rule is Both Face Value and Rank of the card should match");
                        break;
                    }
            }

            Console.WriteLine($"Type D every time you wnat to draw a card");
            Console.WriteLine($"To quit the game please start Q");
            Console.WriteLine($"To shout snap! press S");
            

            Console.WriteLine($"The game will be over once you or your opponent run out of cards");
            Console.WriteLine("The scores will be displayed in the end of the game");

            Console.WriteLine("Now let's start the game");

            Console.WriteLine("Please press D to draw a card");

            DeckFactory factory = new DeckFactory();
            DeckManager manager = new DeckManager();

            ISnapVariation snapVariation = null;

            switch (snapCondition)
            {
                case SnapConditions.FACEVALUE:
                    snapVariation = new RateSnapVariation(factory, manager, deckNumber);
                    break;
                case SnapConditions.SUIT:
                    snapVariation = new SuitSnapVariation(factory, manager, deckNumber);
                    break;
                case SnapConditions.BOTH:
                    snapVariation = new RateSuitVariation(factory, manager, deckNumber);
                    break;

            }
            
            //Call the start of the game
            if (snapVariation != null)
            {
                snapVariation.Play();
            }
        }
    }
}
