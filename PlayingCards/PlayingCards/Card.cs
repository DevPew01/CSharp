using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PlayingCards
{
    class Card
    {
        public int Mast { set; get; }
        public int Val { set; get; }
        public Card(int val, int mast)
        {
            this.Mast = mast;
            this.Val = val;

            switch (val)
            {
                case 6: Val = '6'; break;
                case 7: Val = '7'; break;
                case 8: Val = '8'; break;
                case 9: Val = '9'; break;
                case 10: Val = 'T'; break;
                case 11: Val = 'J'; break;
                case 12: Val = 'Q'; break;
                case 13: Val = 'K'; break;
                case 14: Val = 'A'; break;
            }
            card = $"-------------\n|{(char)Val}{(char)Mast}         |\n|           |\n|           |\n|           |\n" +
                $"|     {(char)Mast}     |\n|           |\n|           |\n|         {(char)Val}{(char)Mast}|\n-------------\n";
              
        }

        private string card;
        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.White;
            if (Mast == 3 || Mast == 4)
                Console.ForegroundColor = ConsoleColor.Red;
            else Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(card);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
