using behavioural_design_pattern._3_Interpreter.Original;

namespace behavioural_design_pattern._3_Interpreter.AfterPattern;

public class PlusExpression : IPostfixExpression
{
    private readonly IPostfixExpression _left;
    private readonly IPostfixExpression _right;

    public PlusExpression(IPostfixExpression left, IPostfixExpression right)
    {
        _left = left;
        _right = right;
    }

    public int Interpret(Dictionary<string, int> context)
    {
        return _left.Interpret(context) + _right.Interpret(context);
    }
    
}