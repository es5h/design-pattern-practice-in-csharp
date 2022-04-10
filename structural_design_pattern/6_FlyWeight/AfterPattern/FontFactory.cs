namespace structural_design_pattern._6_FlyWeight.AfterPattern;

public class FontFactory
{
    private IDictionary<string, Font> cache = new Dictionary<string, Font>();

    public Font GetFont(string font)
    {
        if (cache.ContainsKey(font))
        {
            return cache[font];
        }
        else
        {
            string[] split = font.Split(":");
            Font newFont = new(split[0], Int32.Parse(split[1]));
            cache.Add(font, newFont);
            return newFont;
        }
    }

}