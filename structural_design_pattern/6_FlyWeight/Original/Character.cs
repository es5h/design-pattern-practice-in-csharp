namespace structural_design_pattern._6_FlyWeight.Original;

public class Character
{
    private char _value;
    private string _color;
    private string _fontFamily;
    private int _fontSize;

    public Character(char value, string color, string fontFamily, int fontSize)
    {
        _value = value;
        _color = color;
        _fontFamily = fontFamily;
        _fontSize = fontSize;
    }
}