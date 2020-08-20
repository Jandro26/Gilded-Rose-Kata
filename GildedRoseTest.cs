using Xunit;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRoseTest
    {
        [Fact]
        public void It_should_load_one_item()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
        }
    }
}