namespace behavioural_design_pattern._3_Interpreter.AfterPattern;

public class VariableExpression : IPostfixExpression
{
    private string _variable;

    public VariableExpression(string variable)
    {
        _variable = variable;
    }

    public int Interpret(Dictionary<string, int> context)
    {
        return context[_variable];
    }
}