using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO
{
    class Program
    {
        static void Main(string[] args)
        {
            X_O xo = new X_O();
            ConsoleKey key;
            char win;
            do
            {
                Console.Clear();
                xo.Print();
                xo.GetWinner();
                xo.SetCursor();
                key = Console.ReadKey().Key;
                xo.Move(key);
                win = xo.GetWinner();
                if (win != ' ')
                    xo.SaveToFile(win);
                //SaveToFile(win);
            } while (key != ConsoleKey.Escape);
        }
    }
}
