using System;

namespace BeerCountProject
{
    public class Beer
    {
        public decimal Price { get; set; }
        public int Count { get; private set; }
        public decimal Bill => Price * Count;

        public Beer(decimal price)
        {
            Price = price;
            Count = 0;
        }

        public virtual void Drink()
        {
            Count++;
        }
    }
}
