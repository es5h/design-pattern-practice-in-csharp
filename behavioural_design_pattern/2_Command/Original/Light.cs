namespace behavioural_design_pattern._2_Command.Original;

public class Light
{
    public bool IsOn { get; set; }

    public void On()
    {
        Console.WriteLine("turn on the light.");
        IsOn = true;
    }
    
    public void Off()
    {
        Console.WriteLine("turn off the light.");
        IsOn = false;
    }
    
}