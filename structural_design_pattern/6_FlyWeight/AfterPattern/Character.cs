namespace structural_design_pattern._6_FlyWeight.AfterPattern;

public class Character
{
    private char _value;
    private string _color;
    private Font _font;

    public Character(char value, string color, Font font)
    {
        _value = value;
        _color = color;
        _font = font;
    }
}