namespace design_pattern_practice_in_csharp._3_AbstractFactory.AfterPattern;

public interface IShipFactory
{
    Ship OrderShip(string name, string email)
    {
        Validate(name, email);
        PrepareFor(name);
        Ship ship = CreateShip(); 
        SendEmailTo(email, ship);
        return ship;
    }

    Ship CreateShip();
    private static void Validate(string name, string email)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("we need a name of ship");
        }
        if (string.IsNullOrEmpty(email))
        {
            throw new ArgumentException("we need your email");
        }
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