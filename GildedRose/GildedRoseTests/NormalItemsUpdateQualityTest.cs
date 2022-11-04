using System.Collections.Generic;
using GildedRoseCore;
using GildedRoseCore.QualityHandlers;
using GildedRoseCore.SellInHandlers;
using NUnit.Framework;

namespace GildedRoseTests;

public class NormalItemsUpdateQualityTest
{
    [Test]
    public void ItemsDegradeQualityEachUpdate() {
        Item item = new Item("some item", 1, 20, new DefaultQualityHandler(), new DefaultSellInHandler());

        GildedRose.UpdateQuality(new List<Item> {item});
        
        Assert.AreEqual(19, item.GetQuality());
    }
    
    [Test]
    public void WhenTheSellInDaWhenTheSellInDateHasPassedItemsDegradeQualityTwice() {
        Item item = new Item("some item", 0, 20, new DefaultQualityHandler(), new DefaultSellInHandler());

        GildedRose.UpdateQuality(new List<Item> {item});
        
        Assert.AreEqual(18, item.GetQuality());
    }
    
    [Test]
    public void TheQualityOfAnItemIsNeverNegative() {
        Item item = new Item("some item", 0, 0, new DefaultQualityHandler(), new DefaultSellInHandler());

        GildedRose.UpdateQuality(new List<Item> {item});
        
        Assert.AreEqual(0, item.GetQuality());
    }
}