using System.Security.Authentication.ExtendedProtection;
using structural_design_pattern._2_Bridge.Original;

    namespace structural_design_pattern._2_Bridge.AfterPattern;

public class App
{
    public static void Main(string[] args)
    {
        IChampion kdaAhri = new Ahri(new PoolParty());
        
        kdaAhri.SkillQ();
        kdaAhri.Move();
    }
}