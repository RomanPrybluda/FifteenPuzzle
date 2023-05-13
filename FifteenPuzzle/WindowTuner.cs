using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FifteenPuzzle.Domain;

namespace FifteenPuzzle
{
    public static class WindowTuner
    {
        public static void SetWinProp()
        {
            Console.Title = "==== FifteenPuzzle ====";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
