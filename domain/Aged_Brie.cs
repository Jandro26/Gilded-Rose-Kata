
namespace GildedRoseKata.domain
{
    public class Aged_Brie: Item, IItem
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

            this.SellIn = this.SellIn - 1;


            if (this.SellIn < 0)
            {
                if (this.Quality < 50)
                {
                    this.Quality = this.Quality + 1;
                }
            }
        }
    }
}
