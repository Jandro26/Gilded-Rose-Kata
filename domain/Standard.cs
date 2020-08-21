using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.domain
{
    public class Standard: Item, IItem
    {
        public string GetName()
            => this.Name;

        public int GetSellIn()
            => this.SellIn;

        public int GetQuality()
            => this.Quality;

        public void DoUpdateQuality()
        {
            if (this.Quality > 0)
                this.Quality = this.Quality - 1;

            this.SellIn = this.SellIn - 1;

            if (this.SellIn < 0)
            {
                if (this.Quality > 0)
                    this.Quality = this.Quality - 1;
            }
        }
    }
}
