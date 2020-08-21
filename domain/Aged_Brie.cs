
namespace GildedRoseKata.domain
{
    public class Aged_Brie: Item, IItem
    {
        public Aged_Brie(string name, int sellIn, int quality)
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
            if (this.Quality < 50)  this.Quality ++;
            this.SellIn = this.SellIn - 1;
            if (this.SellIn < 0 && this.Quality < 50) this.Quality ++;
        }
    }
}
