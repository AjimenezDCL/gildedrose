namespace GildedRoseCore.QualityHandlers;

public class DefaultQualityHandler : IQualityHandler
{
    public void UpdateQuality(Item item)
    {
        if(item.GetSellIn() <= 0)
            item.SetQuality(item.GetQuality() - 2);
        else
            item.SetQuality(item.GetQuality() - 1);
    }
}