namespace structural_design_pattern._7_Proxy.AfterPattern_2;

public class Client
{
    public static void Main(string[] args)
    {
        IGameService gameService = new GameServiceProxy(new DefaultGameService());
        gameService.StartGame();
    }
}