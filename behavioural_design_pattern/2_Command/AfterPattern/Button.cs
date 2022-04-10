namespace behavioural_design_pattern._2_Command.AfterPattern;

public class Button 
{
    private ICommand _command;
    
    public Button(ICommand command)
    {
        _command = command;
    }

    public void Press()
    {
        _command.Execute();
    }

    public static void Main(string[] args)
    {
        Button button = new Button(new LightOnCommand(new Light()));
        button.Press();
    }
}