using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.domain
{
    public enum ItemType
    {
        Standard = 0,
        Aged_Brie = 1,
        Backstage_passes = 2,
        Sulfuras = 3,
        Conjured = 4
    }

    public static class ItemFactory
    {
        public static IItem Create(ItemType type, string name, int sellIn, int quality)
        {
            switch (type)
            {
                case ItemType.Standard:
                    return new Standard(name, sellIn, quality);
                case ItemType.Aged_Brie:
                    return new Aged_Brie(name, sellIn, quality);
                case ItemType.Backstage_passes:
                    return new Backstage_passes(name, sellIn, quality);
                case ItemType.Sulfuras:
                    return new Sulfuras(name, sellIn, quality);
                case ItemType.Conjured:
                    return new Conjured(name, sellIn, quality);
                default:
                    throw new Exception("Item Type not found.");
            }
        }
    }
}
