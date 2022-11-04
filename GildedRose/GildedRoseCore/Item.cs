using GildedRoseCore.QualityHandlers;
using GildedRoseCore.SellInHandlers;

namespace GildedRoseCore;

public class Item
{
    public string name { get; }
    private int sellIn;
    private int quality;
    private readonly IQualityHandler qualityHandler;
    private readonly ISellInHandler sellInHandler;

    public Item(string name, int sellIn, int quality, IQualityHandler qualityHandler, ISellInHandler sellInHandler)
    {
        this.name = name;
        SetSellIn(sellIn);
        SetQuality(quality);

        this.qualityHandler = qualityHandler;
        this.sellInHandler = sellInHandler;
    }

    public int GetSellIn()
    {
        return sellIn;
    }

    public void SetSellIn(int sellIn)
    {
        this.sellIn = sellIn;
    }

    public int GetQuality()
    {
        return quality;
    }

    public void SetQuality(int quality)
    {
        this.quality = Math.Max(0, quality);
    }

    public void Update()
    {
        qualityHandler.UpdateQuality(this);
        sellInHandler.UpdateSellIn(this);
    }
}