namespace design_pattern_practice_in_csharp._3_AbstractFactory.AfterPattern
{
    public class ShipInventory
    {
        public static void Main(string[] args)
        {
            IShipFactory shipFactory = new WhiteShipFactory(new WhiteShipPartsProFactory());
            Ship shipWithPro = shipFactory.CreateShip();
            Console.WriteLine(shipWithPro.Anchor.GetType());
            Console.WriteLine(shipWithPro.Wheel.GetType());
            
            shipFactory = new WhiteShipFactory(new WhiteShipPartsFactory());
            Ship shipWithNormal = shipFactory.CreateShip();
            Console.WriteLine(shipWithNormal.Anchor.GetType());
            Console.WriteLine(shipWithNormal.Wheel.GetType());
        }
    }
}