using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.domain
{
    public interface IItem
    {
        public string GetName();
        public int GetSellIn();
        public int GetQuality();
        public void DoUpdateQuality();
    }
}
