namespace creational_design_pattern._2_FactoryMethod.AfterPattern;

public class Ship
{
    public string Name { get; set; } = null!;
    public string Logo { get; set; } = null!;
    public string Color { get; set; } = null!;

    public override string ToString()
    {
        return $"Ship (Name :{Name}, Logo:{Logo}, Color:{Color})";
    }
}