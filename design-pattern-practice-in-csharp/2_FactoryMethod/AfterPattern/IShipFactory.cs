﻿namespace design_pattern_practice_in_csharp_singleton._2_FactoryMethod.AfterPattern;

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
    
    void PrepareFor(string name)
    {
        Console.WriteLine($"preparing {name}");
    }

    void SendEmailTo(string email, Ship ship)
    {
        Console.WriteLine($"{ship.Name} build complete");
    }
}