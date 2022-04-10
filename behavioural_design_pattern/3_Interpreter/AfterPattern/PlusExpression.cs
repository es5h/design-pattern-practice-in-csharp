using behavioural_design_pattern._3_Interpreter.Original;

namespace behavioural_design_pattern._3_Interpreter.AfterPattern;

public class PlusExpression : IPostfixExpression
{
    private IPostfixExpression left, right;

    public PlusExpression(IPostfixExpression left, IPostfixExpression right)
    {
        this.left = left;
        this.right = right;
    }

    public int Interpret(Dictionary<string, int> context)
    {
        return left.Interpret(context) + right.Interpret(context);
    }
    
}