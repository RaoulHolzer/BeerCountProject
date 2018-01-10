﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BeerCountProject.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            AskToStart();
        }

        private static void AskToStart()
        {
            System.Console.Write($"Welcome to the Beer Count Project");
            var key = ReadStartKey();
            do
            {
                if (IsConsoleForStart(key))
                {
                    Start();
                }
                else if (IsConsoleForEnd(key))
                {
                    System.Console.WriteLine("\nGood Bye");
                }
                else
                {
                    System.Console.WriteLine();
                    key = ReadStartKey();
                }
            } while (!IsRightInputforStartOrEnd(key));
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        private static void Start()
        {
            System.Console.WriteLine("\nStart");
            AskForBeerPrice();
        }

        private static void AskForBeerPrice()
        {
            System.Console.WriteLine("How much does the beer cost (decimal)?");
            var line = System.Console.ReadLine();
            if(Decimal.TryParse(line, out decimal price))
            {
                var beer = new Beer(price);
                System.Console.WriteLine($"New Beer created with Price {beer.Price}. Current Bill {beer.Bill}");
            }
        }

        private static bool IsRightInputforStartOrEnd(ConsoleKey consoleKey)
        {
            return IsConsoleForStart(consoleKey) || IsConsoleForEnd(consoleKey);
        }

        private static bool IsConsoleForStart(ConsoleKey consoleKey)
        {
            return consoleKey == ConsoleKey.Y;
        }

        private static bool IsConsoleForEnd(ConsoleKey consoleKey)
        {
            return consoleKey == ConsoleKey.N;
        }

        private static ConsoleKey ReadStartKey()
        {
            System.Console.Write($"\nDo you want to start the beer counter ({ConsoleKey.Y}/{ConsoleKey.N}) ?");
            return System.Console.ReadKey().Key;
        }
    }
}
