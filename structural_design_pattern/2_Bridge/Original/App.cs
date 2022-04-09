namespace structural_design_pattern._2_Bridge.Original;

public class App
{
    public static void Main(string[] args)
    {
        IChampion kdaAhri = new KdaAhri();
        kdaAhri.SkillQ();
        kdaAhri.SkillE();
    }
}