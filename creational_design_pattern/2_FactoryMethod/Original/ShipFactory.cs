namespace design_pattern_practice_in_csharp._2_FactoryMethod.Original;

public static class ShipFactory
{
    public static Ship OrderShip(string name, string email)
    {
        // validation
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("we need a name of ship");
        }
        if (string.IsNullOrEmpty(email))
        {
            throw new ArgumentException("we need your email");
        }

        PrepareFor(name);

        Ship ship = new();
        ship.Name = name;
        
        // Customizing 
        if (name.Equals("whiteship", StringComparison.CurrentCultureIgnoreCase))
        {
            ship.Logo = "white-logo";
        } else if (name.Equals("blackship", StringComparison.CurrentCultureIgnoreCase))
        {
            ship.Logo = "black-logo";
        }
        
        // Color
        if (name.Equals("whiteShip", StringComparison.CurrentCultureIgnoreCase))
        {
            ship.Color = "White";
        } else if (name.Equals("blackShip", StringComparison.CurrentCultureIgnoreCase))
        {
            ship.Color = "Black";
        }
        
        // Notify
        SendEmailTo(email, ship);

        return ship;
    }

    private static void PrepareFor(string name)
    {
        Console.WriteLine($"preparing {name}");
    }

    private static void SendEmailTo(string email, Ship ship)
    {
        Console.WriteLine($"{ship.Name} build complete");
    }
}