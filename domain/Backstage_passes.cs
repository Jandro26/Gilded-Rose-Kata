using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.domain
{
    public class Backstage_passes: Item, IItem
    {
        public Backstage_passes(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public string GetName()
            => this.Name;

        public int GetSellIn()
            => this.SellIn;

        public int GetQuality()
            => this.Quality;

        public void DoUpdateQuality()
        {
            if (this.Quality < 50) this.Quality ++;
            if (this.SellIn < 11 && this.Quality < 50) this.Quality ++;
            if (this.SellIn < 6 && this.Quality < 50) this.Quality ++;
            this.SellIn = this.SellIn - 1;
            if (this.SellIn < 0) this.Quality = 0;
        }
    }
}
