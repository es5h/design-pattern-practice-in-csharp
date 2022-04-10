using System.Diagnostics;

namespace structural_design_pattern._7_Proxy.AfterPattern;

public class GameServiceProxy : GameService
{
    public override void StartGame()
    {
        var sw = Stopwatch.StartNew();
        base.StartGame();
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds.ToString());
    }
}