using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PlayingCards
{
    class Game: IEnumerable, IComparer<Card>
    {
        public Game()
        {
         
        }
        public Game(int count)
        {
            Gamers = new List<Player>();
            PlayesCount = count;
            if (PlayesCount < 2 || PlayesCount > 4)
                Console.WriteLine("At least two players!");
            else
            {
                for (uint i = 0; i < PlayesCount; i++)
                    Gamers.Add(new Player());
            }
        }

        public static int PlayesCount { set; get; }
        private List<Player> Gamers;
        private Deck deck = new Deck();
        public void RandomShuffle()
        {
            Random rnd = new Random();
            int size = 36;
            List<Card> list = new List<Card>(size);
            while (size != 0)
            {
                list.Add(deck.GetDeck.Pop());
                size--;
            }
            deck.GetDeck.Clear();
            for (int i = list.Count - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                var temp = list[j];
                list[j] = list[i];
                list[i] = temp;
                deck.GetDeck.Push(list[i]);
            }
        }

        public void Distribution()
        {
            int newSize = 0;
            newSize = deck.GetDeck.Count / PlayesCount;
            for (int i = 0; i < Gamers.Count; i++)
                Gamers[i].TakeCards(deck.GetDeck);
        }

        public void Play(Player player1, Player player2)
        {
            int cnt = deck.GetDeck.Count;
            while (cnt > 0)
            {
                if (this.Compare(player1.GetCard, player2.GetCard) == 1)
                {
                    Console.WriteLine("Player 1:");
                    player1.GetCard.Draw();
                    Console.WriteLine("Player 2:");
                    player2.GetCard.Draw();
                    player1.TakeCards(player2.GetDeck);
                    Console.WriteLine("Player 1 wins!");
                }
                else if (this.Compare(player1.GetCard, player2.GetCard) == -1)
                {
                    Console.WriteLine("Player 1:");
                    player1.GetCard.Draw();
                    Console.WriteLine("Player 2:");
                    player2.GetCard.Draw();
                    player2.TakeCards(player1.GetDeck);
                    Console.WriteLine("Player 2 wins!");
                }
                else
                {
                    Console.WriteLine("Player 1:");
                    player1.GetCard.Draw();
                    Console.WriteLine("Player 2:");
                    player2.GetCard.Draw();
                    player1.TakeCards(player2.GetDeck);
                    Console.WriteLine("Player 1 wins!");
                }
                cnt--;
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
        public IEnumerator GetEnumerator()
        {
            return Gamers.GetEnumerator();
        }
        public int Count { get { return Gamers.Count; } }
       
        public Player this[int index]
        {
            set
            {
                if (index > 0 && index <= Gamers.Count)
                    Gamers[index] = value;
                else throw new IndexOutOfRangeException(); 
            }
            get
            {
                return Gamers[index];
            }
        }
        public int Compare(Card x, Card y)
        {
            if (x.Val > y.Val)
                return 1;
            else if (x.Val < y.Val)
                return -1;
            else return 0;
        }
    }
}
