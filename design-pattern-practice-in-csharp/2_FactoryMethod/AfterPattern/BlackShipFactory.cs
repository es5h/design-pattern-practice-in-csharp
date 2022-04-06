namespace design_pattern_practice_in_csharp_singleton._2_FactoryMethod.AfterPattern;

public class BlackShipFactory : IShipFactory
{
    public Ship CreateShip()
    {
        return new BlackShip();
    }
}