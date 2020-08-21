﻿using System.Collections.Generic;

namespace GildedRoseKata.domain
{
    public class GildedRose
    {
        IList<IItem> Items;
        public GildedRose(IList<IItem> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.DoUpdateQuality();
            }
        }

        private void DoUpdateQuality(Item item)
        {
            if (item.Name == "Aged Brie")
            {

                if (item.Quality < 50)
                    item.Quality = item.Quality + 1;

                item.SellIn = item.SellIn - 1;


                if (item.SellIn < 0)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }
            else
            {
                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.Quality < 50)
                        item.Quality = item.Quality + 1;

                    if (item.SellIn < 11)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }

                    if (item.SellIn < 6)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }

                    item.SellIn = item.SellIn - 1;

                    if (item.SellIn < 0)
                        item.Quality = item.Quality - item.Quality;
                }
                else
                {
                    if (item.Name == "Sulfuras, Hand of Ragnaros")
                    {
                        if (item.Quality < 50)
                            item.Quality += 1;
                    }
                    else
                    {
                        if (item.Quality > 0)
                            item.Quality = item.Quality - 1;

                        item.SellIn = item.SellIn - 1;

                        if (item.SellIn < 0)
                        {
                            if (item.Quality > 0)
                                item.Quality = item.Quality - 1;
                        }
                    }
                } 
            }
        }
    }
}
