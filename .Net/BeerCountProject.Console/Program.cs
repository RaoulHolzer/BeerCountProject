﻿using System;

namespace BeerCountProject.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RunnConsoleBeerCounter();
        }

        private static void RunnConsoleBeerCounter()
        {
            System.Console.Write($"Welcome to the Beer Count Project");
            var key = ReadStartKey();
            while (!IsConsoleForEnd(key))
            {
                if (IsConsoleForStart(key))
                {
                    Start();
                }
                else
                {
                    System.Console.WriteLine();
                    key = ReadStartKey();
                }
            }
            System.Console.WriteLine($"{Environment.NewLine}Good bye");
        }

        private static void Start()
        {
            System.Console.WriteLine($"{Environment.NewLine}Start");
            var beer = AskForBeerPrice();
            DrinkBeer(beer);
        }

        private static void DrinkBeer(Beer beer)
        {
            ConsoleKeyInfo line = GetDrinkBeerInput();
            while (!IsConsoleForEnd(line.Key))
            {
                if (IsConsoleForStart(line.Key))
                {
                    beer.Drink();                   
                }
                else
                {
                    System.Console.WriteLine($"{Environment.NewLine}Worng input");
                }
                line = GetDrinkBeerInput();
            }
        }

        private static ConsoleKeyInfo GetDrinkBeerInput()
        {
            System.Console.WriteLine("Do you want drink a beer? (Y/N)");
            var line = System.Console.ReadKey();
            return line;
        }

        private static Beer AskForBeerPrice()
        {
            decimal price;
            while (!Decimal.TryParse(GetPriceInput(), out price))
            {
                System.Console.WriteLine("You don't enter a decimal number!\n");
            }
            Beer beer = new ConsoleBeer(price);            
            return beer;
        }

        private static string GetPriceInput()
        {
            System.Console.WriteLine("How much does the beer cost (decimal)?");
            return System.Console.ReadLine();
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
            System.Console.Write($"{Environment.NewLine}Do you want to start the beer counter ({ConsoleKey.Y}/{ConsoleKey.N}) ?");
            return System.Console.ReadKey().Key;
        }
    }
}
