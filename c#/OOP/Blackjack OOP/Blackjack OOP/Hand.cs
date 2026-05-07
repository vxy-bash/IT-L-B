namespace BlackjackOOP
{
    public class Hand // Klasse Hand
    {
        // Variablen werden deklariert
        public int hand_value = 0;
        public List<string> personal_hand = new List<string>();

        public void AddCard(string card) // Methode um Karte zur Hand hinzuzufügen
        {
            personal_hand.Add(card);
        }

        public void CalculateHandValue()   // Methode um den Wert der Hand zu berechnen
        {
            int total = 0;
            int aceCount = 0;
            foreach (var card in personal_hand)
            {
                switch (card) //Hinzufüge des Kartenwerts zum Gesamtwert
                {
                    case "2": total += 2; break;
                    case "3": total += 3; break;
                    case "4": total += 4; break;
                    case "5": total += 5; break;
                    case "6": total += 6; break;
                    case "7": total += 7; break;
                    case "8": total += 8; break;
                    case "9": total += 9; break;
                    case "10":
                    case "Bube":
                    case "Dame":
                    case "König": total += 10; break;
                    case "Ass": total += 11; aceCount++; break;
                }
            }
            while (total > 21 && aceCount > 0) //Anpassung des Asswerts von 11 auf 1, falls Gesamtwert > 21
            {
                total -= 10;
                aceCount--;
            }
            hand_value = total;
        }
    }
}