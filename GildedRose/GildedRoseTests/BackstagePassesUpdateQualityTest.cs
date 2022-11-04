using System.Collections.Generic;
using GildedRoseCore;
using GildedRoseCore.QualityHandlers;
using GildedRoseCore.SellInHandlers;
using NUnit.Framework;

namespace GildedRoseTests;

public class BackstagePassesUpdateQualityTest
{
    [Test]
    public void IncreasesQualityAsTheSellingDayApproaches()
    {
        Item backstagePass = new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20, new BackstageTicketQualityHandler(), new DefaultSellInHandler());

        GildedRose.UpdateQuality(new List<Item> {backstagePass});
        
        Assert.AreEqual(21, backstagePass.GetQuality());
    }
    
    [Test]
    public void IncreasesByTwoIfThereAreBetween10And5DaysToTheSellInDay() {
        Item backstagePass = new Item("Backstage passes to a TAFKAL80ETC concert", 10, 20, new BackstageTicketQualityHandler(), new DefaultSellInHandler());

        GildedRose.UpdateQuality(new List<Item> {backstagePass});
        
        Assert.AreEqual(22, backstagePass.GetQuality());
        
        backstagePass = new Item("Backstage passes to a TAFKAL80ETC concert", 6, 20, new BackstageTicketQualityHandler(), new DefaultSellInHandler());

        GildedRose.UpdateQuality(new List<Item> {backstagePass});
        
        Assert.AreEqual(22, backstagePass.GetQuality());
    }
    
    [Test]
    public void IncreasesByThreeIIncreasesByThreeIfThereAreBetween5And1DaysToTheSellInDay() {
        Item backstagePass = new Item("Backstage passes to a TAFKAL80ETC concert", 5, 20, new BackstageTicketQualityHandler(), new DefaultSellInHandler());

        GildedRose.UpdateQuality(new List<Item> {backstagePass});
        
        Assert.AreEqual(23, backstagePass.GetQuality());
      
        backstagePass = new Item("Backstage passes to a TAFKAL80ETC concert", 1, 20, new BackstageTicketQualityHandler(), new DefaultSellInHandler());

        GildedRose.UpdateQuality(new List<Item> {backstagePass});
        
        Assert.AreEqual(23, backstagePass.GetQuality());
    }
    
    [Test]
    public void QualityIsZeroWhenTheSoldDateHasPassed() {
        Item backstagePass = new Item("Backstage passes to a TAFKAL80ETC concert", 0, 20, new BackstageTicketQualityHandler(), new DefaultSellInHandler());

        GildedRose.UpdateQuality(new List<Item> {backstagePass});
        
        Assert.AreEqual(0, backstagePass.GetQuality());
    }
}