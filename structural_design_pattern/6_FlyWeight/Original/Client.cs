namespace structural_design_pattern._6_FlyWeight.Original;

public class Client
{
    public static void Main(string[] args)
    {
        
        // extrinsic, intrinsic 을 분ㄹ히ㅏ여 재사용성으로 메모리를 줄인다. 인스턴스 많을 때 사용
        
        Character c1 = new Character("h", "white", "Nanum", 13);
        Character c2 = new Character("e", "white", "Nanum", 13);
        Character c3 = new Character("l", "white", "Nanum", 13);
        Character c4 = new Character("l", "white", "Nanum", 13);
        Character c5 = new Character("o", "white", "Nanum", 13);
    }
}