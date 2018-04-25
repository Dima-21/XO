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
            xo.Load();
            ConsoleKey key;
            Console.WriteLine("1. Продолжить");
            Console.WriteLine("2. Новая игра");
            Console.WriteLine("3. Статистика игр");
            key = Console.ReadKey().Key;
            if (key == ConsoleKey.NumPad1)
            { 
                do
                {
                    Console.Clear();
                    xo.Print();
                    if (xo.isWinner())
                    {
                        xo.NewGame();
                        Console.WriteLine($"Для продолжения нажмите любую клавишу...{Console.ReadKey()}");
                    }
                    xo.SetCursor();
                    key = Console.ReadKey().Key;
                    xo.Move(key);
                } while (key != ConsoleKey.Escape);
            }
            else if (key == ConsoleKey.NumPad2)
            {
                xo.NewGame();
                do
                {
                    Console.Clear();
                    xo.Print();
                    if (xo.isWinner())
                        xo.NewGame();
                    xo.SetCursor();
                    key = Console.ReadKey().Key;
                    xo.Move(key);
                } while (key != ConsoleKey.Escape);
            }
            else if (key == ConsoleKey.NumPad3)
            {
                Console.Clear();
                xo.PrintStats();
            }
            xo.Save();
        }
    }
}
