namespace structural_design_pattern._3_Composite.AfterPattern;

public class Bag : IComponent
{
    public List<IComponent> Components { get; } = new List<IComponent>();
    public int Price => Components.Select(x => x.Price).Sum();

    public void Add(IComponent component)
    {
        Components.Add(component);
    }
    
}