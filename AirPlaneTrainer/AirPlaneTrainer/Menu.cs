using System;
using System.Collections.Generic;

namespace AirPlaneTrainer
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
            return $"    {_Item}      ";
        }
    };

    class Menu
    {
        public int Size { set; get; }
        public int Current { set; get; }
        List<Item> items;

        public void OutputMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   Menu");
            for (int i = 0; i < Size; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (i == Current)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("=>");
                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
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
                            Current--;
                            Console.Clear();
                            OutputMenu();
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            Current++;
                            Console.Clear();
                            OutputMenu();
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            Console.Clear();
                            return Current;
                        }
                }
                if (Current > Size)
                    Current = 0;
                else if (Current < 0)
                    Current = Size;
            }
        }

        public Menu()
        {
            items = new List<Item>
            {
                new Item("Start fligth"),
                new Item("Add dispatcher"),
                new Item("Remove dispatcher"),
                new Item("exit")
            };
            Current = 0;
            Size = 4;
        }
    }
}