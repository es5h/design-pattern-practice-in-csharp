using creational_design_pattern._3_AbstractFactory.AfterPattern.ProProduct;

namespace creational_design_pattern._3_AbstractFactory.AfterPattern;

public class WhiteShipPartsProFactory : IShipPartsFactory
{
    public IWheel CreateWheal()
    {
        return new WhiteWheelPro();
    }

    public IAnchor CreateAnchor()
    {
        return new WhiteAnchorPro();
    }
}