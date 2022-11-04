namespace GildedRoseCore;

public class GildedRose
{
    public static void UpdateQuality(List<Item> items)
    {
        foreach (Item item in items)
        {
            item.Update();
        }
        return;
        for (int i = 0; i < items.Count; i++)
        {
            if ((!"Aged Brie".Equals(items[i].name)) && !"Backstage passes to a TAFKAL80ETC concert".Equals(items[i].name))
            {
                if (items[i].GetQuality() > 0)
                {
                    if (!"Sulfuras, Hand of Ragnaros".Equals(items[i].name))
                    {
                        items[i].SetQuality(items[i].GetQuality() - 1);
                    }
                }
            }
            else
            {
                if (items[i].GetQuality() < 50)
                {
                    items[i].SetQuality(items[i].GetQuality() + 1);

                    if ("Backstage passes to a TAFKAL80ETC concert".Equals(items[i].name))
                    {
                        if (items[i].GetSellIn() < 11)
                        {
                            if (items[i].GetQuality() < 50)
                            {
                                items[i].SetQuality(items[i].GetQuality() + 1);
                            }
                        }

                        if (items[i].GetSellIn() < 6)
                        {
                            if (items[i].GetQuality() < 50)
                            {
                                items[i].SetQuality(items[i].GetQuality() + 1);
                            }
                        }
                    }
                }
            }

            if (!"Sulfuras, Hand of Ragnaros".Equals(items[i].name))
            {
                items[i].SetSellIn(items[i].GetSellIn() - 1);
            }

            if (items[i].GetSellIn() < 0)
            {
                if (!"Aged Brie".Equals(items[i].name))
                {
                    if (!"Backstage passes to a TAFKAL80ETC concert".Equals(items[i].name))
                    {
                        if (items[i].GetQuality() > 0)
                        {
                            if (!"Sulfuras, Hand of Ragnaros".Equals(items[i].name))
                            {
                                items[i].SetQuality(items[i].GetQuality() - 1);
                            }
                        }
                    }
                    else
                    {
                        items[i].SetQuality(items[i].GetQuality() - items[i].GetQuality());
                    }
                }
                else
                {
                    if (items[i].GetQuality() < 50)
                    {
                        items[i].SetQuality(items[i].GetQuality() + 1);
                    }
                }
            }
        }
    }
}