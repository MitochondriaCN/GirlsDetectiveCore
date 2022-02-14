using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirlsDetectiveCore.Tools
{
    internal static class ConsoleRenderer
    {
        internal static void TitlePara(string title)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("            " + title + "            ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        internal static void Para(string text)
        {
            Console.ResetColor();
            Console.WriteLine(text);
        }
    }
}
