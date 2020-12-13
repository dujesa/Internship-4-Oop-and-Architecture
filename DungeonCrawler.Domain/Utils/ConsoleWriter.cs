using DungeonCrawler.Domain.Services;
using System;

namespace DungeonCrawler.Domain.Utils
{
    public static class ConsoleWriter
    {
        public static void ColoredWrite(string text, ConsoleColor textColor)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void ColoredWriteColoredBackground(string text, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void StartGameConsole()
        {
            Console.WindowHeight = 50;
            Console.WindowWidth = 150;

            ColoredWriteColoredBackground("--------------------DUNGEON CRAWLER GAME--------------------\n\n", ConsoleColor.Black, ConsoleColor.White);
        }

        public static void EndGameConsole()
        {
            ColoredWriteColoredBackground($"\n\n" +
                $"-----------------------------------------------------------------\n" +
                $"Your score was {GameManager.GetNumberOfGamesWon()} games won!\n" +
                $"Thanks for playing game.", ConsoleColor.Black, ConsoleColor.White);
        }

        public static void BlockWriteWithCaption(string caption, string text)
        {
            Console.WriteLine("\n------------------------------" + caption + "------------------------------\n");
            Console.WriteLine(text);
            Console.WriteLine("\n-----------------------------------------------------------------\n");
        }

        public static void BlockWrite(string text)
        { 
            Console.WriteLine("\n-----------------------------------------------------------------\n");
            Console.WriteLine(text);
            Console.WriteLine("\n-----------------------------------------------------------------\n");
        }

        public static void ColoredBlockWrite(string text, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            Console.WriteLine("\n-----------------------------------------------------------------\n");
            ColoredWriteColoredBackground(text, foregroundColor, backgroundColor);
            Console.WriteLine("\n-----------------------------------------------------------------\n");
        }
    }
}
