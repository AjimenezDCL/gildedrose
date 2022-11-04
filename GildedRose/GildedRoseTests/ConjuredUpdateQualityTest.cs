using System.Collections.Generic;
using GildedRoseCore;
using GildedRoseCore.QualityHandlers;
using GildedRoseCore.SellInHandlers;
using NUnit.Framework;

namespace GildedRoseTests;

public class ConjuredUpdateQualityTest
{
    [Test]
    public void QualityDecreasedByTwo()
    {
        Item conjured = new Item("Conjured", 0, 10, new ConjuredQualityHandler(), new DefaultSellInHandler());
        
        GildedRose.UpdateQuality(new List<Item> {conjured});
        
        Assert.AreEqual(8, conjured.GetQuality());
    }
    
    [Test]
    public void NeverDecreasesQuality() {
        Item conjured = new Item("Conjured", 0, 1, new ConjuredQualityHandler(), new DefaultSellInHandler());
        
        GildedRose.UpdateQuality(new List<Item> {conjured});
        
        Assert.AreEqual(0, conjured.GetQuality());
    }
}