using System;
using System.Collections.Generic;
using System.Linq; // Braucht man für Shuffle und so'n Zeug, glaub ich.

// ------------ Die Karten ------------
public enum Suit
{
    Hearts,   // Herz
    Diamonds, // Karo
    Clubs,    // Kreuz
    Spades    // Pik
}

public enum Rank
{
    Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
    Jack = 10, Queen = 10, King = 10, Ace = 11 // Ass ist 11, aber kann auch 1 sein bei Blackjack
}

public class Card
{
    public Suit Suit { get; private set; }
    public Rank Rank { get; private set; }

    public Card(Suit suit, Rank rank)
    {
        Suit = suit;
        Rank = rank;
    }

    public void PrintCard() // Damit man sieht, was man hat
    {
        Console.WriteLine($"{Rank} of {Suit}");
    }

    public int GetValue()
    {
        // Ass muss extra behandelt werden, weil's 1 oder 11 sein kann.
        // Fürs Erste mal 11, die Logik kommt dann im Spieler.
        return (int)Rank;
    }
}

// ------------ Das Kartendeck ------------
public class Deck
{
    private List<Card> cards;

    public Deck()
    {
        cards = new List<Card>();
        InitializeDeck();
        Shuffle(); // Immer mischen, sonst is' langweilig
    }

    private void InitializeDeck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                cards.Add(new Card(suit, rank));
            }
        }
    }

    public void Shuffle()
    {
        // Hier kommt der "Skibidi Shuffle" rein, wie die KI sagt.
        // Zufälliges Mischen halt.
        Random rng = new Random();
        cards = cards.OrderBy(a => rng.Next()).ToList();
    }

    public Card DealCard()
    {
        if (cards.Count == 0)
        {
            Console.WriteLine("Deck ist leer, muss neu gemischt werden!");
            InitializeDeck();
            Shuffle();
        }
        Card card = cards[0];
        cards.RemoveAt(0);
        return card;
    }
}

// ------------ Der Spieler (und der Dealer) ------------
public class Player
{
    public List<Card> Hand { get; private set; }
    public string Name { get; private set; }

    public Player(string name)
    {
        Name = name;
        Hand = new List<Card>();
    }

    public void AddCard(Card card)
    {
        Hand.Add(card);
    }

    public int GetHandValue()
    {
        int value = 0;
        int aceCount = 0;

        foreach (var card in Hand)
        {
            if (card.Rank == Rank.Ace)
            {
                aceCount++;
            }
            value += card.GetValue();
        }

        // Ass-Logik: Wenn Wert über 21 und Ass dabei ist, wird Ass zu 1
        while (value > 21 && aceCount > 0)
        {
            value -= 10; // Aus 11 wird 1
            aceCount--;
        }
        return value;
    }

    public void ShowHand(bool hideFirstCard = false)
    {
        Console.WriteLine($"\n{Name}'s Hand ({GetHandValue()}):");
        for (int i = 0; i < Hand.Count; i++)
        {
            if (hideFirstCard && i == 0)
            {
                Console.WriteLine("[Verdeckte Karte]");
            }
            else
            {
                Hand[i].PrintCard();
            }
        }
    }

    public void ClearHand()
    {
        Hand.Clear();
    }
}

// ------------ Das Spiel selber ------------
public class BlackjackGame
{
    private Deck deck;
    private Player player;
    private Player dealer; // Der Dealer ist auch ein Player

    public BlackjackGame()
    {
        deck = new Deck();
        player = new Player("Du");
        dealer = new Player("Dealer");
    }

    public void StartGame()
    {
        Console.WriteLine("--- Blackjack: Jetzt geht's los! ---");
        player.ClearHand();
        dealer.ClearHand();
        deck = new Deck(); // Neues Deck für jede Runde

        // Erste Karten verteilen
        player.AddCard(deck.DealCard());
        dealer.AddCard(deck.DealCard());
        player.AddCard(deck.DealCard());
        dealer.AddCard(deck.DealCard());

        // Hände zeigen
        player.ShowHand();
        dealer.ShowHand(true); // Dealer's erste Karte ist verdeckt

        // Spielerzug
        PlayerTurn();

        // Dealerzug (wenn Spieler nicht busted hat)
        if (player.GetHandValue() <= 21)
        {
            DealerTurn();
        }

        // Ergebnisse anzeigen
        DetermineWinner();

        Console.WriteLine("\n--- Runde beendet ---");
        Console.WriteLine("Willst du nochmal spielen? (j/n)");
        string input = Console.ReadLine().ToLower();
        if (input == "j")
        {
            StartGame(); // Wenn ja, dann nochmal
        }
        else
        {
            Console.WriteLine("Tschüss! Ich geh jetzt Kebap essen.");
        }
    }

    private void PlayerTurn()
    {
        while (player.GetHandValue() < 21)
        {
            Console.WriteLine("\nWillst du 'hit' (noch eine Karte) oder 'stand' (bleiben)? (h/s)");
            string input = Console.ReadLine().ToLower();

            if (input == "h")
            {
                Card newCard = deck.DealCard();
                player.AddCard(newCard);
                Console.WriteLine($"Du ziehst: ");
                newCard.PrintCard();
                player.ShowHand();
                if (player.GetHandValue() > 21)
                {
                    Console.WriteLine("Du hast überkauft (Bust)! Dein Wert ist über 21.");
                    break;
                }
            }
            else if (input == "s")
            {
                Console.WriteLine("Du bleibst stehen.");
                break;
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Versuch's nochmal.");
            }
        }
    }

    private void DealerTurn()
    {
        Console.WriteLine("\n--- Dealer's Zug ---");
        dealer.ShowHand(false); // Dealer zeigt jetzt beide Karten

        // Dealer zieht, bis er mindestens 17 hat
        while (dealer.GetHandValue() < 17)
        {
            Card newCard = deck.DealCard();
            dealer.AddCard(newCard);
            Console.WriteLine($"Dealer zieht: ");
            newCard.PrintCard();
            dealer.ShowHand(false);
            if (dealer.GetHandValue() > 21)
            {
                Console.WriteLine("Dealer hat überkauft (Bust)! Dein Wert ist über 21.");
                break;
            }
            System.Threading.Thread.Sleep(1000); // Bissl warten, damit man's lesen kann
        }
        Console.WriteLine($"Dealer bleibt bei {dealer.GetHandValue()} stehen.");
    }

    private void DetermineWinner()
    {
        int playerValue = player.GetHandValue();
        int dealerValue = dealer.GetHandValue();

        Console.WriteLine($"\n--- Spielergebnisse ---");
        player.ShowHand();
        dealer.ShowHand(false);

        if (playerValue > 21)
        {
            Console.WriteLine("Du hast überkauft. Dealer gewinnt!");
        }
        else if (dealerValue > 21)
        {
            Console.WriteLine("Dealer hat überkauft. Du gewinnst!");
        }
        else if (playerValue > dealerValue)
        {
            Console.WriteLine("Du gewinnst!");
        }
        else if (dealerValue > playerValue)
        {
            Console.WriteLine("Dealer gewinnt!");
        }
        else
        {
            Console.WriteLine("Unentschieden (Push)!");
        }
    }
}

// ------------ Hauptprogramm ------------
class Program
{
    static void Main(string[] args)
    {
        BlackjackGame game = new BlackjackGame();
        game.StartGame();
    }
}