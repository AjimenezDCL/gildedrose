using System.Collections.Generic;
using GildedRoseCore;
using GildedRoseCore.QualityHandlers;
using GildedRoseCore.SellInHandlers;
using NUnit.Framework;

namespace GildedRoseTests;

public class SulfurasUpdateQualityTest
{
    [Test]
    public void NeverHasToBeSold()
    {
        Item sulfuras = new Item("Sulfuras, Hand of Ragnaros", 0, 80, new DefaultQualityHandler(), new DefaultSellInHandler());
        
        GildedRose.UpdateQuality(new List<Item> {sulfuras});
        
        Assert.AreEqual(0, sulfuras.GetSellIn());
    }
    
    [Test]
    public void NeverDecreasesQuality() {
        Item sulfuras = new Item("Sulfuras, Hand of Ragnaros", 0, 80, new DefaultQualityHandler(), new DefaultSellInHandler());
        
        GildedRose.UpdateQuality(new List<Item> {sulfuras});
        
        Assert.AreEqual(80, sulfuras.GetQuality());
    }
}