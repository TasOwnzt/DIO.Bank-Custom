using System;

namespace DIO.Bank.Libs
{
    public class Utils
    {
        public static void MenssageAlertCustom(string msg, ConsoleColor newColor, bool aroundNewLine = true)
        {
            // Change the color of Console for a moment
            Console.ForegroundColor = newColor;

            if (aroundNewLine)
                Console.WriteLine("\n" + msg + "\n");
            else
                Console.WriteLine(msg);

            Console.ResetColor();
        }
        public static void ClearScreen()
        {
            Console.Clear();
        }
    }
}