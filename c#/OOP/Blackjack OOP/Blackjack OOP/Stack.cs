namespace BlackjackOOP
{
    public class Stack
    {
        // Instanziierung der Klasse Card
        Card card = new Card();
        // Array für das Kartendeck
        public string[] stack = new string[52];

        public void GenerateStack()
        {
            Random random = new Random();
            for (int i = 0; i < 52; i++)
            {
                int num = random.Next(0, 13);
                stack[i] = card.cards[num];
            }
        }
    }

}