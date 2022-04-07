namespace design_pattern_practice_in_csharp_singleton._3_AbstractFactory.AfterPattern;

// 추상 팩토리
public interface IShipPartsFactory
{
    IWheel CreateWheal();
    IAnchor CreateAnchor();
}