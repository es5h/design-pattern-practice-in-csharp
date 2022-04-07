using design_pattern_practice_in_csharp_singleton._3_AbstractFactory.AfterPattern.ProProduct;

namespace design_pattern_practice_in_csharp_singleton._3_AbstractFactory.AfterPattern;

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