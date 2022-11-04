namespace GildedRoseCore.QualityHandlers;

public class BackstageTicketQualityHandler : IQualityHandler
{
    public void UpdateQuality(Item item)
    {
        var daysToConcert = item.GetSellIn();
        if (daysToConcert > 10)
        {
            item.SetQuality(item.GetQuality() + 1);
            return;
        }

        if (daysToConcert > 5)
        {
            item.SetQuality(item.GetQuality() + 2);
            return;
        }

        if (daysToConcert > 0)
        {
            item.SetQuality(item.GetQuality() + 3);
            return;
        }

        item.SetQuality(0);
    }
}

public class ConjuredQualityHandler : IQualityHandler
{

    public void UpdateQuality(Item item)
    {
        item.SetQuality(item.GetQuality() - 2);
    }
}