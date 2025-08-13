namespace GameLibraries.Poker
{
    public class Card
    {
        public string Suit { get; set; } // Will fit the Format "H", "D", "C", "S"
        public int Value { get; set; } // Js are 11, Qs are 12, Ks are 13, As are 1 or 14
        public string PictureName { get; set; }

        public Card(string suit, int value, string pictureName)
        {
            Suit = suit;
            Value = value;
            PictureName = pictureName;
        }

        public override string ToString()
        {
            Faces face = (Faces)Value;
            return $"{face} of {Suit} ({PictureName})";
        }
    }
}

public enum Faces
{
    Ace = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Jack = 11,
    Queen = 12,
    King = 13
}