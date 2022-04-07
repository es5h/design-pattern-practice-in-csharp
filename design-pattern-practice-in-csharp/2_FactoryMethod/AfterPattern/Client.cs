namespace design_pattern_practice_in_csharp_singleton._2_FactoryMethod.AfterPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            Client client = new();

            IShipFactory whiteShipFactory = new WhiteShipFactory();
            Print(new WhiteShipFactory(), "person1", "person1@gmail.com");
            Print(new BlackShipFactory(), "person2", "person2@gmail.com");
            
            /*Ship whiteShip = whiteShipFactory.OrderShip("name", "ancd@abcd.com");
            Console.WriteLine(whiteShip);

            IShipFactory blackShipFactory = new BlackShipFactory();
            Ship blackShip = blackShipFactory.OrderShip("BlackShip", "abcd@abcd.com");
            Console.WriteLine(blackShip);*/
        }

        // Dependency Injection
        private static void Print(IShipFactory shipFactory, string name, string email)
        {
            Console.WriteLine(shipFactory.OrderShip(name, email));
        }
    }
}