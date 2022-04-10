namespace structural_design_pattern._6_FlyWeight.AfterPattern;

public sealed class Font
{
    private readonly string _family;
    private readonly int _size;

    public Font(string family, int size)
    {
        _family = family;
        _size = size;
    }
}