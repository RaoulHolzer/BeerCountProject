using System;
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
                    System.Console.WriteLine("\nGood bye");
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
            var beer = AskForBeerPrice();
            DrinkBeer(beer);
        }

        private static void DrinkBeer(Beer beer)
        {
            System.Console.WriteLine("Do you want drink a beer? (Y/N)");
            var line = System.Console.ReadKey();
            do
            {
                if (IsConsoleForStart(line.Key))
                {
                    beer.Drink();
                    System.Console.WriteLine($"\nYou have drunk {beer.Count} beers. Current bill {beer.Bill}");
                }
                else
                {
                    System.Console.WriteLine("Worng input/n");
                }
                System.Console.WriteLine("Do you want drink a beer? (Y/N)");
                line = System.Console.ReadKey();
            } while (IsConsoleForEnd(line.Key));
        }

        private static Beer AskForBeerPrice()
        {       
            decimal price;
            while (Decimal.TryParse(GetPriceInput(), out price))
            {
                System.Console.WriteLine("You don't enter a decimal number!\n");
            }
            Beer beer = new Beer(price);
            System.Console.WriteLine($"New beer created with price {beer.Price}. Current bill {beer.Bill}");
            return beer;
        }

        private static string GetPriceInput()
        {
            System.Console.WriteLine("How much does the beer cost (decimal)?");
            return System.Console.ReadLine();
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
