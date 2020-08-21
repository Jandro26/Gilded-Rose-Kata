using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.domain
{
    public class Conjured: Item, IItem
    {
        public Conjured(string name, int sellIn, int quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
        }

        public string GetName()
            => this.Name;

        public int GetSellIn()
            => this.SellIn;

        public int GetQuality()
            => this.Quality;

        public void DoUpdateQuality()
        {
            this.SellIn = this.SellIn - 1;
            updateQuality();
            updateQuality();
        }
        
        private void updateQuality()
        {
            if (this.Quality > 0) this.Quality--;
            if (this.SellIn < 0 && this.Quality > 0) this.Quality--;
        }
    }
}
