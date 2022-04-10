namespace structural_design_pattern._7_Proxy.AfterPattern_2;

public class DefaultGameService : IGameService
{
    public void StartGame()
    {
        Console.WriteLine("welcome to the world.");
    }
}