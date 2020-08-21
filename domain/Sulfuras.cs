using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.domain
{
    public class Sulfuras: Item, IItem
    {
        public Sulfuras(string name, int sellIn, int quality)
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
        }
    }
}
