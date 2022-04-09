using creational_design_pattern._3_AbstractFactory.AfterPattern.NormalProduct;

namespace creational_design_pattern._3_AbstractFactory.AfterPattern;

public class WhiteShipPartsFactory : IShipPartsFactory
{
    public IWheel CreateWheal()
    {
        return new WhiteWheel(); 
    }

    public IAnchor CreateAnchor()
    {
        return new WhiteAnchor();
    }
}