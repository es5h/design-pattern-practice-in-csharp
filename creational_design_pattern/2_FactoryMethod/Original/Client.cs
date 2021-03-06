namespace creational_design_pattern._2_FactoryMethod.Original;

public class Client
{
    public static void Main(string[] args)
    {
        Client client = new();

        Ship whiteShip = ShipFactory.OrderShip("WhiteShip", "abcd@abcd.com");
        Console.WriteLine(whiteShip);
        
        Ship blackShip = ShipFactory.OrderShip("BlackShip", "abcd@abcd.com");
        Console.WriteLine(blackShip);
    }
}