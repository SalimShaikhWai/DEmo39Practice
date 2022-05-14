using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39CaseStudy.ConsoleHelp
{
    public class ConsoleHelper
    {




        public static void WriteText(int width, string text)
        {
            if (text == null)
                text = "null";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            int val = width - text.Length;
            string leftString = new string(' ', val / 2);
            string rightString = new string(' ', val / 2);
            Console.Write(leftString + text + rightString);
            Console.ResetColor();
        }


        public static void WriteHeader(int width, string text)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(new String('-', width));
            int val = width - text.Length;
            string leftString = '|' + new string(' ', (val / 2) - 1);
            string rightString = new string(' ', (val / 2) - 1) + "|";
            Console.WriteLine(leftString + text + rightString);


            Console.WriteLine(new String('-', width));
            Console.ResetColor();
        }
        public static void DrawLine(int width)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            string line = new string('_', width);
            Console.WriteLine(line);
            Console.ResetColor();
        }
        public static void WriteLine()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.ResetColor();

        }
        public static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
