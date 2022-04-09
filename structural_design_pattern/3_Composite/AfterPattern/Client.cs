namespace structural_design_pattern._3_Composite.AfterPattern;

public class Client
{
    public static void Main(string[] args)
    {
        Item doranBlade = new()
        {
            Name = "도란검",
            Price = 450
        };

        Item healPotion = new()
        {
            Name = "체력 물약",
            Price = 50,
        };

        Bag bag = new();
        bag.Add(doranBlade);
        bag.Add(healPotion);

        Client client = new Client();
        client.PrintPrice(doranBlade);
        client.PrintPrice(bag);
    }

    private void PrintPrice(IComponent component)
    {
        Console.WriteLine(component.Price);
    }
}