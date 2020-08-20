using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                DegradeOnce(Items[i]);
                if (Items[i].Name != "Sulfuras, Hand of Ragnaros") Items[i].SellIn = Items[i].SellIn - 1;
                DegradesTwice(Items[i]);
            }
        }

        private void DegradeOnce(Item item)
        {
            if (IsQualityDegrades(item))
                item.Quality = item.Quality - 1;
            else
            {
                IncreaseItemQuality(item);
                BackstageIncreaseItems(item);
            }
        }

        private void DegradesTwice(Item item)
        {
            if (item.SellIn < 0)
            {
                if (IsQualityDegrades(item)) item.Quality = item.Quality - 1;
                if (item.Name == "Backstage passes to a TAFKAL80ETC concert") item.Quality = 0;
                if (item.Name == "Aged Brie") IncreaseItemQuality(item);
            }
        }

        private bool IsQualityDegrades(Item item)
        => item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert" && item.Name != "Sulfuras, Hand of Ragnaros" && item.Quality > 0;

        private void IncreaseItemQuality(Item item)
        {
            if (item.Quality < 50) item.Quality += 1;
        }

        private void BackstageIncreaseItems(Item item)
        {
            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.SellIn < 11) IncreaseItemQuality(item);
                if (item.SellIn < 6) IncreaseItemQuality(item);
            }
        }
    }
}
