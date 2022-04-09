using creational_design_pattern._2_FactoryMethod.AfterPattern;

namespace creational_design_pattern._3_AbstractFactory.Original;

// Client에 해당하는 클래스 (예시 혼동 주의)
public class WhiteShipFactory : IShipFactory
{
    public Ship CreateShip()
    {
        Ship ship = new WhiteShip();
        
        // 구체적인 클래스에 의존함
        // ship.Anchor = new WhiteAnchor();
        // ship.Wheel = new WhiteWheel();

        return ship;
    }
}