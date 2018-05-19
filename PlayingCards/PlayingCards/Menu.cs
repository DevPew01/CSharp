using System;
using System.Collections.Generic;
using System.Media;
using System.Linq;
using System.Text;
using System.Collections;

namespace PlayingCards
{
    class Item
    {
        public Item(string item)
        {
            _Item = item;
        }
        string _Item { set; get; }

        public override string ToString()
        {
            return $"|{(char)3}    {_Item}     {(char)4}|";
        }
    };

    class Menu
    {
        public int Size { set; get; }
        public int Current { set; get; }
        List<Item> items;

        public void OutputMenu()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (i == Current)
                {
                    Console.Beep(200, 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                if (Current < 0) Current = Size;
                else if (Current > Size) Current = 0;
            }
        }
        public int ShowMenu()
        {
            OutputMenu();
            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            Console.Clear();
                            Current--;
                            OutputMenu();
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                           Console.Clear();
                            Current++;
                            OutputMenu();
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            Console.Beep(500, 100);
                            Console.Clear();
                            return Current;
                        }
                }
            }
        }

        public Menu()
        {
            items = new List<Item>();
            items.Add(new Item("  New game "));
            items.Add(new Item("  Options  "));
            items.Add(new Item("   Exit    "));
            Current = 0;
            Size = 3;
        }
    }
}
