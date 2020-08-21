using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.domain
{
    public class Backstage_passes: Item, IItem
    {
        public string GetName()
            => this.Name;

        public int GetSellIn()
            => this.SellIn;

        public int GetQuality()
            => this.Quality;

        public void DoUpdateQuality()
        {
            if (this.Quality < 50)
                this.Quality = this.Quality + 1;

            if (this.SellIn < 11)
            {
                if (this.Quality < 50)
                {
                    this.Quality = this.Quality + 1;
                }
            }

            if (this.SellIn < 6)
            {
                if (this.Quality < 50)
                {
                    this.Quality = this.Quality + 1;
                }
            }

            this.SellIn = this.SellIn - 1;

            if (this.SellIn < 0)
                this.Quality = this.Quality - this.Quality;
        }
    }
}
