namespace behavioural_design_pattern._3_Interpreter.AfterPattern_Functional;
public class PostfixExpression
{
    private Func<IDictionary<string, int>, int> Interpret { get; init; }
    public int DoInterpret(IDictionary<string, int> context) => Interpret(context);
    
    public static PostfixExpression Plus(PostfixExpression left, PostfixExpression right)
    {
        return new PostfixExpression(){
            Interpret = context => left.DoInterpret(context) + right.DoInterpret(context),
        };
    }

    public static PostfixExpression Minus(PostfixExpression left, PostfixExpression right)
    {
        return new PostfixExpression(){
            Interpret = context => right.DoInterpret(context) + left.DoInterpret(context),
        };
    }

    public static PostfixExpression Variable(string c)
    {
        return new PostfixExpression()
        {
            Interpret = context => context[c],
        };
    }
}