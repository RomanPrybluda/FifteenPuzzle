using FifteenPuzzle.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenPuzzle
{
    internal class GuiGame
    {
        private Board _board;

        public GuiGame()
        {
            _board = new Board();
            Play();
        }

        public void Play()
        {
            while (true)
            {
                PrintBoard();
                MoveField();

                if (_board.IsVictory())
                {
                    PrintVictoryMsg();
                    Exit();
                }

                Console.Clear();

            }
        }

        public void PrintBoard()
        {
            int f00 = _board.GameField[0, 0];
            int f01 = _board.GameField[0, 1];
            int f02 = _board.GameField[0, 2];
            int f03 = _board.GameField[0, 3];

            int f10 = _board.GameField[1, 0];
            int f11 = _board.GameField[1, 1];
            int f12 = _board.GameField[1, 2];
            int f13 = _board.GameField[1, 3];

            int f20 = _board.GameField[2, 0];
            int f21 = _board.GameField[2, 1];
            int f22 = _board.GameField[2, 2];
            int f23 = _board.GameField[2, 3];

            int f30 = _board.GameField[3, 0];
            int f31 = _board.GameField[3, 1];
            int f32 = _board.GameField[3, 2];
            int f33 = _board.GameField[3, 3];

            Console.OutputEncoding = Encoding.UTF8;

            int w = 16;
            int w1 = w / 4;
            int w2 = (w / 4) * 2;
            int w3 = (w / 4) * 3;

            Console.WriteLine(" ");

            for (int i = 0; i <= w; i++)
            {
                if (i == 0)
                    Console.Write('╔');
                if (i == w1 || i == w2 || i == w3)
                    Console.Write('╦');
                if (i == w)
                    Console.Write('╗');
                else Console.Write('═');
            }

            Console.WriteLine(" ");

            // 1 Line 00
            for (int i = 0; i <= w; i++)
            {
                if (i == 0)
                {
                    Console.Write('║');
                }

                if (i == w1)
                {
                    if (f00 == 16)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write($" {f00,2:D} ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('║');
                }

                if (i == w2)
                {
                    if (f01 == 16)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write($" {f01,2:D} ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('║');
                }


                if (i == w3)
                {
                    if (f02 == 16)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write($" {f02,2:D} ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('║');
                }

                if (i == w)
                {
                    if (f03 == 16)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write($" {f03,2:D} ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('║');
                }
            }

            Console.WriteLine(" ");

            for (int i = 0; i <= w; i++)
            {
                if (i == 0)
                    Console.Write('╠');
                if (i == w1 || i == w2 || i == w3)
                    Console.Write('╬');
                if (i == w)
                    Console.Write('╣');
                else Console.Write('═');
            }

            Console.WriteLine(" ");

            // 2 Line 10
            for (int i = 0; i <= w; i++)
            {
                if (i == 0)
                {
                    Console.Write('║');
                }

                if (i == w1)
                {
                    if (f10 == 16)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write($" {f10,2:D} ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('║');
                }

                if (i == w2)
                {
                    if (f11 == 16)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write($" {f11,2:D} ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('║');
                }

                if (i == w3)
                {
                    if (f12 == 16)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write($" {f12,2:D} ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('║');
                }

                if (i == w)
                {
                    if (f13 == 16)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write($" {f13,2:D} ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('║');
                }
            }

            Console.WriteLine(" ");

            for (int i = 0; i <= w; i++)
            {
                if (i == 0)
                    Console.Write('╠');
                if (i == w1 || i == w2 || i == w3)
                    Console.Write('╬');
                if (i == w)
                    Console.Write('╣');
                else Console.Write('═');
            }

            Console.WriteLine(" ");

            // 3 Line 20
            for (int i = 0; i <= w; i++)
            {
                if (i == 0)
                {
                    Console.Write('║');
                }

                if (i == w1)
                {
                    if (f20 == 16)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write($" {f20,2:D} ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('║');
                }

                if (i == w2)
                {
                    if (f21 == 16)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write($" {f21,2:D} ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('║');
                }

                if (i == w3)
                {
                    if (f22 == 16)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write($" {f22,2:D} ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('║');
                }

                if (i == w)
                {
                    if (f23 == 16)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write($" {f23,2:D} ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('║');
                }
            }

            Console.WriteLine(" ");

            for (int i = 0; i <= w; i++)
            {
                if (i == 0)
                    Console.Write('╠');
                if (i == w1 || i == w2 || i == w3)
                    Console.Write('╬');
                if (i == w)
                    Console.Write('╣');
                else Console.Write('═');
            }

            Console.WriteLine(" ");

            // 4 Line 30
            for (int i = 0; i <= w; i++)
            {
                if (i == 0)
                {
                    Console.Write('║');
                }

                if (i == w1)
                {
                    if (f30 == 16)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write($" {f30,2:D} ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('║');
                }

                if (i == w2)
                {
                    if (f31 == 16)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write($" {f31,2:D} ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('║');
                }

                if (i == w3)
                {
                    if (f32 == 16)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write($" {f32,2:D} ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('║');
                }

                if (i == w)
                {
                    if (f33 == 16)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write($" {f33,2:D} ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('║');
                }
            }

            Console.WriteLine(" ");

            for (int i = 0; i <= w; i++)
            {
                if (i == 0)
                    Console.Write('╚');
                if (i == w1 || i == w2 || i == w3)
                    Console.Write('╩');
                if (i == w)
                    Console.Write('╝');
                else Console.Write('═');
            }
        }

        public void MoveField()
        {
            Console.Write("\n    Use arrows " +
                "\n   to move fiels");

            var arrow = Console.ReadKey().Key;

            if (arrow == ConsoleKey.LeftArrow)
                _board.MoveRight();

            if (arrow == ConsoleKey.RightArrow)
                _board.MoveLeft();

            if (arrow == ConsoleKey.UpArrow)
                _board.MoveDown();

            if (arrow == ConsoleKey.DownArrow)
                _board.MoveUp();
        }

        public void PrintVictoryMsg()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n ----- Victory! ----- ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Exit()
        {
            Console.WriteLine("\n Press ENTER for new game" +
                              "\n or Escape for exit.");

            var exit = Console.ReadKey().Key;

            if (exit == ConsoleKey.Escape)
            {
                Console.WriteLine("\n\n ----- Good bay ----- ");
                Thread.Sleep(1200);
                Environment.Exit(0);
            }

        }

    }
}
