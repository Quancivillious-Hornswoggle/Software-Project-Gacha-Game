namespace GameLibraries.Poker
{
    public class Card
    {
        public string Suit { get; set; } // Will fit the Format "H", "D", "C", "S"
        public int Value { get; set; } // Js are 11, Qs are 12, Ks are 13, As are 1
        public string PictureName { get; set; }

        public Card(string suit, int value, string pictureName)
        {
            Suit = suit;
            Value = value;
            PictureName = pictureName;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit} ({PictureName})";
        }
    }
}