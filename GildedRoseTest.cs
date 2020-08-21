﻿using Xunit;
using System.Collections.Generic;
using GildedRoseKata.domain;

namespace GildedRoseKata
{
    public class GildedRoseTest
    {
        [Fact]
        public void It_should_load_one_item()
        {
            IList<IItem> Items = new List<IItem> { new Standard { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].GetName());
        }

        [Fact]
        public void It_should_sellin_and_quality_lower_one()
        {
            IList<IItem> Items = new List<IItem> { new Standard { Name = "foo", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(4, Items[0].GetSellIn());
            Assert.Equal(4, Items[0].GetQuality());
        }

        [Fact]
        public void It_should_quality_lower_Twice_when_sell_by_date_passed()
        {
            IList<IItem> Items = new List<IItem> { new Standard { Name = "foo", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(-1, Items[0].GetSellIn());
            Assert.Equal(3, Items[0].GetQuality());
        }

        [Fact]
        public void It_should_quality_be_positive()
        {
            IList<IItem> Items = new List<IItem> { new Standard { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(-1, Items[0].GetSellIn());
            Assert.Equal(0, Items[0].GetQuality());
        }

        [Fact]
        public void It_should_aged_brie_increase_allways_in_quality()
        {
            IList<IItem> Items = new List<IItem> { new Aged_Brie { Name = "Aged Brie", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(4, Items[0].GetSellIn());
            Assert.Equal(6, Items[0].GetQuality());
        }

        [Fact]
        public void It_should_quality_be_maximum_50()
        {
            IList<IItem> Items = new List<IItem> { new Aged_Brie { Name = "Aged Brie", SellIn = 5, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(4, Items[0].GetSellIn());
            Assert.Equal(50, Items[0].GetQuality());
        }

        [Fact]
        public void It_should_sulfuras_never_been_decrease_in_quality()
        {
            IList<IItem> Items = new List<IItem> { new Sulfuras { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 40 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(5, Items[0].GetSellIn());
            Assert.Equal(41, Items[0].GetQuality());
        }

        [Fact]
        public void It_should_backstage_passes_increase_twice_when_there_are_10_days_or_less()
        {
            IList<IItem> Items = new List<IItem> { new Backstage_passes { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 8, Quality = 40 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(7, Items[0].GetSellIn());
            Assert.Equal(42, Items[0].GetQuality());
        }

        [Fact]
        public void It_should_backstage_passes_increase_three_times_when_there_are_5_days_or_less()
        {
            IList<IItem> Items = new List<IItem> { new Backstage_passes { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 40 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(4, Items[0].GetSellIn());
            Assert.Equal(43, Items[0].GetQuality());
        }

        [Fact]
        public void It_should_backstage_passes_quality_drop_to_0_after_the_concert()
        {
            IList<IItem> Items = new List<IItem> { new Backstage_passes { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 40 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(-1, Items[0].GetSellIn());
            Assert.Equal(0, Items[0].GetQuality());
        }

    }
}