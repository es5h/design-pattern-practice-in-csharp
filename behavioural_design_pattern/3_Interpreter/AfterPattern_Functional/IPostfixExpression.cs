namespace behavioural_design_pattern._3_Interpreter.AfterPattern_Functional;
public class PostfixExpression
{
    private PostfixExpression(Func<IDictionary<string, int>, int> interpretDelegate)
    {
        InterpretDelegate = InterpretDelegate;
    }
    
    private Func<IDictionary<string, int>, int> InterpretDelegate { get; init; }
    public int Interpret(IDictionary<string, int> context) => InterpretDelegate(context);
    
    public static PostfixExpression Plus(PostfixExpression left, PostfixExpression right) 
        => new PostfixExpression(context => left.Interpret(context) + right.Interpret(context));
    public static PostfixExpression Minus(PostfixExpression left, PostfixExpression right) 
        => new PostfixExpression(context => left.Interpret(context) - right.Interpret(context));
    public static PostfixExpression Variable(string c) 
        => new PostfixExpression(context => context[c]);
}