using GildedRoseKata.domain;
using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<IItem> Items = new List<IItem>{
                ItemFactory.Create (ItemType.Standard, "+5 Dexterity Vest", 10, 20),
                ItemFactory.Create ( ItemType.Aged_Brie, "Aged Brie", 2, 0),
                ItemFactory.Create ( ItemType.Standard, "Elixir of the Mongoose", 5, 7),
                ItemFactory.Create ( ItemType.Sulfuras, "Sulfuras, Hand of Ragnaros", 0, 80),
                ItemFactory.Create ( ItemType.Sulfuras, "Sulfuras, Hand of Ragnaros", -1, 80),
                ItemFactory.Create ( ItemType.Backstage_passes, "Backstage passes to a TAFKAL80ETC concert", 15, 20),
                ItemFactory.Create ( ItemType.Backstage_passes, "Backstage passes to a TAFKAL80ETC concert", 10, 49),
                ItemFactory.Create ( ItemType.Backstage_passes, "Backstage passes to a TAFKAL80ETC concert", 5, 49),
				// this conjured item does not work properly yet
				ItemFactory.Create ( ItemType.Conjured, "Conjured Mana Cake", 3, 6),
            };

            var app = new GildedRose(Items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j].GetName() + ", " + Items[j].GetSellIn() + ", " + Items[j].GetQuality());
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
