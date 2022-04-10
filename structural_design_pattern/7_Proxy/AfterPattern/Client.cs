namespace structural_design_pattern._7_Proxy.AfterPattern;

public class Client
{
    public static void Main(string[] args)
    {
        GameService gameService = new GameServiceProxy();
        // Startgame 의 시간을 재고 싶다 그러면 위아래의 이런 코드를 작성행할까?
        // time start
        gameService.StartGame();
        // time end
    }
}