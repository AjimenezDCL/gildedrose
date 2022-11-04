namespace GildedRoseCore.QualityHandlers;

public class TheOlderTheBetterQualityHandler : IQualityHandler
{
    public void UpdateQuality(Item item)
    {
        item.SetQuality(item.GetQuality() + 1);
    }
}