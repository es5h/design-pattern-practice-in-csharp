namespace creational_design_pattern._3_AbstractFactory.AfterPattern;

public class Ship
{
    public string Name { get; set; } = null!;
    public string Logo { get; set; } = null!;
    public string Color { get; set; } = null!;

    public IWheel Wheel { get; set; } = null!;
    public IAnchor Anchor { get; set; } = null!;

    public override string ToString()
    {
        return $"Ship (Name :{Name}, Logo:{Logo}, Color:{Color})";
    }
}