using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PlayingCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            while (true)
            {
                switch (menu.ShowMenu())
                {
                    case 0:
                        {
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            int PlayerCount = 0;
                            while (PlayerCount < 2 || PlayerCount > 4)
                            {
                                Console.Write("Please, enter the number of players: ");
                                PlayerCount = Int32.Parse(Console.ReadLine());
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(10, 5);
                            Console.WriteLine("Loading");
                            Console.SetCursorPosition(0, 6);
                            for (int i = 0; i < 30; i++)
                            {
                                Thread.Sleep(100); Console.Write('.');
                            }
                            Console.WriteLine();
                            Console.ResetColor();
                            Console.Clear();
                            Game game = new Game(PlayerCount);
                            game.RandomShuffle();
                            game.Distribution();
                            game.Play(game[0], game[1]);
                            Console.ResetColor();
                            break;
                        }
                    case 1:
                        {
                            break;
                        }
                    case 2:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
