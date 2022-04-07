namespace design_pattern_practice_in_csharp_singleton._3_AbstractFactory.AfterPattern;

public class WhiteShipFactory : IShipFactory
{
    private IShipPartsFactory _shipPartsFactory;

    public WhiteShipFactory(IShipPartsFactory shipPartsFactory)
    {
        _shipPartsFactory = shipPartsFactory;
    }

    public Ship CreateShip()
    {
        Ship ship = new WhiteShip();
        ship.Anchor = _shipPartsFactory.CreateAnchor();
        ship.Wheel = _shipPartsFactory.CreateWheal();

        return ship;
    }
}