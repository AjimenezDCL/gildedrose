namespace GildedRoseCore;

public class GildedRose
{
    public static void UpdateQuality(List<Item> items)
    {
        foreach (Item item in items)
        {
            item.Update();
        }
    }
}