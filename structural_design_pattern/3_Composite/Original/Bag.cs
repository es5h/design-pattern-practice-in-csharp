namespace structural_design_pattern._3_Composite.Original;

public class Bag
{
    public List<Item> Items { get; } = new List<Item>();

    public void Add(Item item)
    {
        Items.Add(item);
    }
}