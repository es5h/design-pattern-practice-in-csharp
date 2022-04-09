namespace structural_design_pattern._2_Bridge.Original;

public class KdaAhri : IChampion
{
    public void Move()
    {
        Console.WriteLine("KdaAhri Move");
    }

    public void SkillQ()
    {
        Console.WriteLine("KdaAhri Q");
    }

    public void SkillW()
    {
        Console.WriteLine("KdaAhri W");
    }

    public void SkillE()
    {
        Console.WriteLine("KdaAhri E");
    }

    public void SkillR()
    {
        Console.WriteLine("KdaAhri R");
    }
}