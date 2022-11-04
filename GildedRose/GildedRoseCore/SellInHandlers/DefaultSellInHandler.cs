namespace GildedRoseCore.SellInHandlers;

public class DefaultSellInHandler : ISellInHandler
{
    public void UpdateSellIn(Item item)
    {
        item.SetSellIn(item.GetSellIn() - 1);
    }
}