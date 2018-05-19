using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCards
{
    class Player
    {
        public Player()
        {

        }
        public Player(string name)
        {
            Name = name;
        }

        public void TakeCards(Stack<Card> stack)
        {
            int cnt = stack.Count / Game.PlayesCount;
            while (cnt != 0)
            {
                queue.Enqueue(stack.Pop());
                cnt--;
            }
        }

        public void TakeCards(Queue<Card> queue)
        {
            int cnt = queue.Count / Game.PlayesCount;
            while (cnt != 0)
            {
                this.queue.Enqueue(queue.Dequeue());
                cnt--;
            }
        }
        public void Show()
        {
            foreach (Card item in queue)
                item.Draw();
        }
        public string Name { set; get; }
        private Queue<Card> queue = new Queue<Card>();

        public Queue<Card> GetDeck
        {
            get { return this.queue; }
        }

        public Card GetCard { get { return queue.Dequeue(); } }
    }
}
