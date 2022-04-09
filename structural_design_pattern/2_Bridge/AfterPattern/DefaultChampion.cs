using structural_design_pattern._2_Bridge.Original;

namespace structural_design_pattern._2_Bridge.AfterPattern;

public class DefaultChampion : IChampion
{
    private ISkin _skin;
    private string _name;

    public DefaultChampion(ISkin skin, string name)
    {
        _skin = skin;
        _name = name;
    }

    public void Move()
    {
        Console.WriteLine($"{_skin.Name}  {_name} Move");
    }

    public void SkillQ()
    {
        Console.WriteLine($"{_skin.Name}  {_name} Q");
    }

    public void SkillW()
    {
        Console.WriteLine($"{_skin.Name}  {_name} W");
    }

    public void SkillE()
    {
        Console.WriteLine($"{_skin.Name}  {_name} E");
    }

    public void SkillR()
    {
        Console.WriteLine($"{_skin.Name}  {_name} R");
    }
}