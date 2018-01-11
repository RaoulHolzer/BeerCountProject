using System;

namespace BeerCountProject.Console
{
    public class Beer
    {
        public decimal Price { get; set; }
        public int Count { get; private set; }
        public decimal Bill => Price * Count;

        public Beer(decimal _price)
        {
            Price = _price;
            Count = 0;
        }

        public virtual void Drink()
        {
            Count++;
        }
    }
}
