using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO
{
    class X_O
    {
        char[,] symbol = new char[3, 3];
        Position pos = new Position { X = 0, Y = 0 };
        Position cursorpos = new Position { X = 1, Y = 1 };
        char[] xo = new char[]{ 'X', 'O' };
        int indexs;
        const string field = @"
   |   |
 - + - + -
   |   |
 - + - + -
   |   |
                                    ";
        public void Move(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    cursorpos.X -= 4;
                    pos.X--;
                    break;
                case ConsoleKey.RightArrow:
                    cursorpos.X += 4;
                    pos.X++;
                    break;
                case ConsoleKey.DownArrow:
                    cursorpos.Y += 2;
                    pos.Y++;
                    break;
                case ConsoleKey.UpArrow:
                    cursorpos.Y -= 2;
                    pos.Y--;
                    break;
                case ConsoleKey.Enter:
                    
                    break;
            }
            if (cursorpos.X < 1 || cursorpos.X > 9)
            {
                cursorpos.X = 1;
                pos.X = 0;
                pos.Y = 0;
            }
            else if (cursorpos.Y < 1 || cursorpos.Y > 6)
            {
                cursorpos.Y = 1;
                pos.X = 0;
                pos.Y = 0;
            }
        }

        public void Print()
        {
            Console.WriteLine(field);
        }
        public void SetCursor()
        {
            Console.SetCursorPosition(cursorpos.X, cursorpos.Y);
        }

    }
}
