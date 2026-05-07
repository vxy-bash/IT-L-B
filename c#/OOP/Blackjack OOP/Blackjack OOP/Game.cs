using BlackjackOOP;

// Die Hauptklasse für das Spiel
public class Game
{
    // Startet eine Blackjack-Spielrunde
    public void PlayBlackJack()
    {
        // Spieler initialisieren
        Player player1 = InitializePlayer();

        // Solange der Spieler noch Geld hat
        while (player1.balance > 0)
        {
            int cardIndex = 0;
            Stack newStack = new Stack();
            newStack.GenerateStack(); // Neues Kartendeck generieren
            Hand playerHand = new Hand();
            Hand dealerHand = new Hand();

            Console.Clear();
            Console.WriteLine($"Current Balance: {player1.balance}");
            Console.WriteLine("How much are you betting?");
            // Einsatz abfragen und überprüfen
            if (!int.TryParse(Console.ReadLine(), out int bid) || bid > player1.balance || bid <= 0)
            {
                bid = Math.Min(10, player1.balance);
                Console.WriteLine($"Invalid input. Defaulting bid to {bid}");
            }

            // Zu Beginn je zwei Karten an Spieler und Dealer ausgeben
            for (int i = 0; i < 2; i++)
            {
                playerHand.AddCard(newStack.stack[cardIndex++]);
                dealerHand.AddCard(newStack.stack[cardIndex++]);
            }

            playerHand.CalculateHandValue();
            dealerHand.CalculateHandValue();

            // Spielerzug: Karten nehmen ("Hit") oder stehen bleiben ("Stand")
            while (true)
            {
                Console.WriteLine("\nYour Hand:");
                foreach (var card in playerHand.personal_hand)
                    Console.WriteLine(card);
                Console.WriteLine($"Hand Value: {playerHand.hand_value}");

                // Überprüfung auf Blackjack oder Bust
                if (playerHand.hand_value == 21)
                {
                    Console.WriteLine("Blackjack! You win!");
                    player1.balance += bid;
                    break;
                }
                else if (playerHand.hand_value > 21)
                {
                    Console.WriteLine("Bust! You lose!");
                    player1.balance -= bid;
                    break;
                }

                Console.WriteLine("Would you like to (H)it or (S)tand?");
                string choice = Console.ReadLine().ToUpper();

                // "Hit" -> Eine weitere Karte nehmen
                if (choice == "H")
                {
                    playerHand.AddCard(newStack.stack[cardIndex++]);
                    playerHand.CalculateHandValue();
                }
                // "Stand" -> Zug beenden
                else if (choice == "S")
                {
                    break;
                }
            }

            // Dealerzug: Karten ziehen bis mindestens 17
            if (playerHand.hand_value <= 21)
            {
                while (dealerHand.hand_value < 17)
                {
                    dealerHand.AddCard(newStack.stack[cardIndex++]);
                    dealerHand.CalculateHandValue();
                }

                // Hände vergleichen und Gewinner bestimmen
                Console.WriteLine("\nDealer's Hand:");
                foreach (var card in dealerHand.personal_hand)
                    Console.WriteLine(card);
                Console.WriteLine($"Dealer's Hand Value: {dealerHand.hand_value}");

                if (dealerHand.hand_value > 21 || playerHand.hand_value > dealerHand.hand_value)
                {
                    Console.WriteLine("You win!");
                    player1.balance += bid;
                }
                else if (playerHand.hand_value < dealerHand.hand_value)
                {
                    Console.WriteLine("You lose!");
                    player1.balance -= bid;
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }
            }

            // Prüfen ob Geld weg
            if (player1.balance <= 0)
            {
                Console.WriteLine("You're out of money! Game over.");
                break;
            }

            // Nachfrage, ob eine weitere Runde gespielt werden soll
            Console.WriteLine("\nDo you want to play another round? (Y/N)");
            string again = Console.ReadLine().ToUpper();
            if (again != "Y") break;
        }
    }

    // Initialisiert den Spieler beim Spielstart
    private Player InitializePlayer()
    {
        Console.WriteLine("Welcome to Blackjack!");
        Console.WriteLine("What's your name?");
        string temp = Console.ReadLine();
        Player player1 = new Player { name = temp };
        Console.WriteLine($"Hello {player1.name}! Starting balance: {player1.balance}");
        return player1;
    }
}