



public enum Suit
{
    Hearts,
    Spades,
    Diamonds,
    Clubs,
}

public enum Rank
{
    Ace,
    Two,
    Three,
    Four,
    Five,
    Six, 
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King,
    Joker,
}

public record Card
{
    public Suit? Suit {get; set;}
    public Rank Rank {get; set;}
}

public record Deck
{    
    public List<Card> Cards { get; set; }

    public Deck()
    {
        List<Card> deck = [];

        foreach (Suit.  suit in Enum.GetValues<Suit>())
        {
            foreach (Rank rank in Enum.GetValues<Rank>())
            {   
                

                deck.Add(new Card()
                {
                    Suit = suit,
                    Rank = rank,
                });
            }
        }
