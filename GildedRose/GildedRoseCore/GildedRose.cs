namespace GildedRoseCore;

public class GildedRose
{
    public static void UpdateQuality(List<Item> items)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if ((!"Aged Brie".Equals(items[i].GetName())) && !"Backstage passes to a TAFKAL80ETC concert".Equals(items[i].GetName()))
            {
                if (items[i].GetQuality() > 0)
                {
                    if (!"Sulfuras, Hand of Ragnaros".Equals(items[i].GetName()))
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

                    if ("Backstage passes to a TAFKAL80ETC concert".Equals(items[i].GetName()))
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

            if (!"Sulfuras, Hand of Ragnaros".Equals(items[i].GetName()))
            {
                items[i].SetSellIn(items[i].GetSellIn() - 1);
            }

            if (items[i].GetSellIn() < 0)
            {
                if (!"Aged Brie".Equals(items[i].GetName()))
                {
                    if (!"Backstage passes to a TAFKAL80ETC concert".Equals(items[i].GetName()))
                    {
                        if (items[i].GetQuality() > 0)
                        {
                            if (!"Sulfuras, Hand of Ragnaros".Equals(items[i].GetName()))
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