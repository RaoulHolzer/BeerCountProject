using System;

namespace BeerCountProject.Console
{
    class ConsoleBeer : Beer
    {
        public ConsoleBeer(decimal _price) : base(_price)
        {
            System.Console.WriteLine($"New beer created with price {Price}. Current bill {Bill}");
        }

        public override void Drink()
        {
            base.Drink();
            System.Console.WriteLine($"{Environment.NewLine}You have drunk {Count} beers. Current bill {Bill}");
        }      
    }
}
