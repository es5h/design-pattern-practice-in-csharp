using System.Diagnostics;

namespace structural_design_pattern._7_Proxy.AfterPattern_2;

public class GameServiceProxy : IGameService
{
    private readonly IGameService _gameService;

    public GameServiceProxy(IGameService gameService)
    {
        _gameService = gameService;
    }

    public void StartGame()
    {
        var sw = Stopwatch.StartNew();
        _gameService.StartGame();
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds.ToString());
    }
}