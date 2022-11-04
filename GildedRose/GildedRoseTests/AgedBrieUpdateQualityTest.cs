using System.Collections.Generic;
using GildedRoseCore;
using GildedRoseCore.QualityHandlers;
using GildedRoseCore.SellInHandlers;
using NUnit.Framework;

namespace GildedRoseTests;

public class AgedBrieUpdateQualityTest
{
    [Test]
    public void IncreasesQualityTheOlderItGets()
    {
        Item agedBrie = new Item("Aged Brie", 1, 1, new DefaultQualityHandler(), new DefaultSellInHandler());

        GildedRose.UpdateQuality(new List<Item>{agedBrie});
        
        Assert.AreEqual(2, agedBrie.GetQuality());
    }
    
    [Test]
    public void NeverIncreasesOver50()
    {
        Item agedBrie = new Item("Aged Brie", 1, 50, new DefaultQualityHandler(), new DefaultSellInHandler());

        GildedRose.UpdateQuality(new List<Item>{agedBrie});
        
        Assert.AreEqual(50, agedBrie.GetQuality());
    }
}