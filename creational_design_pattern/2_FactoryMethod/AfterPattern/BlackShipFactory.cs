namespace creational_design_pattern._2_FactoryMethod.AfterPattern;

public class BlackShipFactory : IShipFactory
{
    public Ship CreateShip()
    {
        return new BlackShip();
    }
}