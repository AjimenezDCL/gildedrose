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
    private readonly int maxQualityAllowed;

    public Item(string name, int sellIn, int quality, IQualityHandler qualityHandler, ISellInHandler sellInHandler, int maxQualityAllowed = 50)
    {
        this.maxQualityAllowed = maxQualityAllowed;
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
        this.quality = Math.Clamp(quality, 0, maxQualityAllowed);
    }

    public void Update()
    {
        qualityHandler.UpdateQuality(this);
        sellInHandler.UpdateSellIn(this);
    }
}