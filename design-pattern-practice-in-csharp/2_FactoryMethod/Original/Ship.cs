namespace design_pattern_practice_in_csharp_singleton._2_FactoryMethod.Original;

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