namespace behavioural_design_pattern._2_Command.Original;

public class Button
{
    private Light _light;

    public Button(Light light)
    {
        _light = light;
    }

    public void press()
    {
        _light.Off();
    }

    public static void Main(string[] args)
    {
        Button button = new(new Light());
        button.press();
    }
    
}