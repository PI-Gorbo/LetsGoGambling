// namespace Practice;
// public enum Suit
// {
//     Hearts,
//     Spades,
//     Diamonds,
//     Clubs,
// }

// public enum Rank
// {
//     Ace,
//     Two,
//     Three,
//     Four,
//     Five,
//     Six, 
//     Seven,
//     Eight,
//     Nine,
//     Ten,
//     Jack,
//     Queen,
//     King,
    
// }
// public enum JokerType
// {
//     Joker1,
//     Joker2,
// }

// public abstract record Card
// {
//     public record SuitCard : Card
//     {
//         public Suit Suit {get; set;}
//         public Rank Rank {get; set;}
//     }    

//     public record JokerCard : Card
//     {
//         public JokerType JokerType {get; set; }
//     }
// }

// public record Deck
// {     
//     public List<Card> Cards { get; set; }
        
//     public Deck(bool UserAskedToIncludeJoker)
//     {
//         Card card1 = new Card();
        
//         Console.WriteLine(card1.GetType().Name);

//         // List<Card> deck = [];

//         // if (UserAskedToIncludeJoker == true)
//         // {
//         //     foreach (JokerType jokerType in enum.GetValues<JokerType>())
//         //     deck.add(new JokerCard()
//         //     {
//         //         JokerType = jokerType
//         //     });



//         // }
        
        
            
        

//         // foreach (Suit suit in Enum.GetValues<Suit>())
//         // {
//         //     foreach (Rank rank in Enum.GetValues<Rank>())
//         //     {   
               

//         //         deck.Add(new Card()
//         //         {
//         //             Suit = suit,
//         //             Rank = rank,
                    
//         //         });
//         //     }
//         // }

//         // var myNullableCard = new Card()
//         // {
//         //     Rank = Rank.Joker,
//         //     Suit = null  
//         // };

//         // var myCard = new Card()
//         // {
//         //     Rank = Rank.Eight,
//         //     Suit = Suit.Diamonds
//         // };

//         // this.Cards = deck;
//     }
// }


// internal class Program
// {
//     private static void Main(string[] args)
//     {
//        var deckWithJoker = new Deck(true);
//     //    var deckWithoutJoker = new Deck(false);

//     //    Console.WriteLine($"Deck with joker card count: {deckWithJoker.Cards.Count}");
//     //    Console.WriteLine($"Deck without joker card count: {deckWithoutJoker.Cards.Count}");
//     }
// }
