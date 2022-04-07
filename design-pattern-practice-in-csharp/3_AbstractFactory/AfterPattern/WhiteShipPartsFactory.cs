namespace design_pattern_practice_in_csharp_singleton._3_AbstractFactory.AfterPattern;

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