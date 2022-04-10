namespace structural_design_pattern._6_FlyWeight.AfterPattern;

public class Client
{
    public static void Main(string[] args)
    {
        FontFactory fontFactory = new();
        
        // 인스턴스 재활용 
        
        Character c1 = new ('h', "white", fontFactory.GetFont("nanum:12"));
        Character c2 = new ('e', "white", fontFactory.GetFont("nanum:12"));
        Character c3 = new ('l', "white", fontFactory.GetFont("nanum:12"));
    }
}