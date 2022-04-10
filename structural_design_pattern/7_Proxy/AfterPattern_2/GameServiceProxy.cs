using System.Diagnostics;

namespace structural_design_pattern._7_Proxy.AfterPattern_2;

public class GameServiceProxy : IGameService
{
    private IGameService _gameService;


    public void StartGame()
    {
        var sw = Stopwatch.StartNew();
        if (_gameService == null)
        {
            _gameService = new DefaultGameService();
        }

        _gameService.StartGame();
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds.ToString());
    }
}