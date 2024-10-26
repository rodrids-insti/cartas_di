namespace Classes
{
    public class Deck
    {
        private const int size = 52;
        private List<Card> cards = new List<Card>(size);
        private int pos_actual = 0;

        public Deck()
        {
            foreach (Palos palo in Enum.GetValues(typeof(Palos)))
            {
                foreach (Valores valor in Enum.GetValues(typeof(Valores)))
                {
                    cards.Add(new Card(palo, valor));
                }
            }
        }

        public Card nextCard()
        {
            return cards[pos_actual++];
        }
        public void sacarCarta()
        {
            cards[pos_actual].showCard();
        }
        public void barajar()
        {
            Random n = new Random();

            for (int i = cards.Count - 1; i > 0; i--)
            {
                int pos = n.Next(0, i + 1);
                Card temp = cards[i];
                cards[i] = cards[pos];
                cards[pos] = temp;
            }
        }
    }
}
