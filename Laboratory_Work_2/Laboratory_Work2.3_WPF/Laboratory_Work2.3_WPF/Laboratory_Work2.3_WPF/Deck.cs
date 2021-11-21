using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work2._3_WPF
{
    class Deck
    {
        Card[] cards = new Card[54];

        public Deck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    cards[j + (i * 13)] = new Card((rank)j, (suit)i);
                }
            }
            cards[52] = new Card((rank)13, (suit)3);
            cards[53] = new Card((rank)14, (suit)3);
        }

        public void SetCard()
        {

        }

        public Card GetCard(int i)
        {
            return cards[i];
        }

        public void Shuffle()
        {
            var random = new Random(DateTime.Now.Millisecond);
            cards = cards.OrderBy(x => random.Next()).ToArray();
            
        }



    }
}
