namespace creational_design_pattern._3_AbstractFactory.AfterPattern;

// 추상 팩토리
public interface IShipPartsFactory
{
    IWheel CreateWheal();
    IAnchor CreateAnchor();
}