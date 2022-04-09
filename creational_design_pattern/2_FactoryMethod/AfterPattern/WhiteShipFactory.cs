namespace creational_design_pattern._2_FactoryMethod.AfterPattern;

public class WhiteShipFactory : IShipFactory
{
    public Ship CreateShip()
    {
        return new WhiteShip();
    }
}