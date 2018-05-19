using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCards
{
    class Deck
    {
        public Deck()
        {
            deck.Push(new Card(6, 6)); deck.Push(new Card(6, 3)); deck.Push(new Card(6, 4)); deck.Push(new Card(6, 5));
            deck.Push(new Card(7, 6)); deck.Push(new Card(7, 3)); deck.Push(new Card(7, 4)); deck.Push(new Card(7, 5));
            deck.Push(new Card(8, 6)); deck.Push(new Card(8, 3)); deck.Push(new Card(8, 4)); deck.Push(new Card(8, 5));
            deck.Push(new Card(9, 6)); deck.Push(new Card(9, 3)); deck.Push(new Card(9, 4)); deck.Push(new Card(9, 5));
            deck.Push(new Card(10, 6)); deck.Push(new Card(10, 3)); deck.Push(new Card(10, 4)); deck.Push(new Card(10, 5));
            deck.Push(new Card(11, 6)); deck.Push(new Card(11, 3)); deck.Push(new Card(11, 4)); deck.Push(new Card(11, 5));
            deck.Push(new Card(12, 6)); deck.Push(new Card(12, 3)); deck.Push(new Card(12, 4)); deck.Push(new Card(12, 5));
            deck.Push(new Card(13, 6)); deck.Push(new Card(13, 3)); deck.Push(new Card(13, 4)); deck.Push(new Card(13, 5));
            deck.Push(new Card(14, 6)); deck.Push(new Card(14, 3)); deck.Push(new Card(14, 4)); deck.Push(new Card(14, 5));
        }
        private Stack<Card> deck = new Stack<Card>();

        public Stack<Card> GetDeck
        {
            get { return deck; }
        }
    }
}
