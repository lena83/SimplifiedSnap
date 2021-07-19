using System;

namespace SimplifiedSnap.Enums
{
    /// <summary>
    /// Possible card suits
    /// </summary>
    public enum Suit
    {
        CLUB = 1,
        DIAMOND = 2,
        HEART = 3,
        SPADE = 4
    }

    /// <summary>
    /// Possible card ranking ordered
    /// </summary>
    public enum Rank
    {
        ACE = 1,
        TWO = 2,
        THREE = 3,
        FOUR = 4,
        FIVE = 5,
        SIX = 6,
        SEVEN = 7,
        EIGHT = 8,
        NINE = 9,
        TEN = 10,
        JACK = 11,
        QUEEN = 12,
        KING = 13
    }

    public enum SnapConditions
    {
        UNDEFINED = 0,
        FACEVALUE = 1,
        SUIT = 2,
        BOTH = 3
    }
}
