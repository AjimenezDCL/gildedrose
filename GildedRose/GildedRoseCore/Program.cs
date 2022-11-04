using GildedRoseCore;
using GildedRoseCore.QualityHandlers;
using GildedRoseCore.SellInHandlers;

var defaultQHandler = new DefaultQualityHandler();
var defaultSellInHandler = new DefaultSellInHandler();

List<Item> items = new List<Item>();

items.Add(new Item("+5 Dexterity Vest", 10, 20, defaultQHandler, defaultSellInHandler));
items.Add(new Item("Aged Brie", 2, 0, defaultQHandler, defaultSellInHandler));
items.Add(new Item("Elixir of the Mongoose", 5, 7, defaultQHandler, defaultSellInHandler));
items.Add(new Item("Sulfuras, Hand of Ragnaros", 0, 80, defaultQHandler, defaultSellInHandler));
items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20, defaultQHandler, defaultSellInHandler));
items.Add(new Item("Conjured Mana Cake", 3, 6, defaultQHandler, defaultSellInHandler));

GildedRose.UpdateQuality(items);

foreach (var item in items)
{
    Console.WriteLine("Item: " + item.name + ",Quality: " + item.GetQuality() + ",SellIn: " + item.GetSellIn());
}