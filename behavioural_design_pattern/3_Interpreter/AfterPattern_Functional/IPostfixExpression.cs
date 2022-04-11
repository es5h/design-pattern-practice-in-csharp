namespace behavioural_design_pattern._3_Interpreter.AfterPattern_Functional;
public class PostfixExpression
{
    private PostfixExpression(Func<IDictionary<string, int>, int> interpret)
    {
        Interpret = interpret;
    }

    private Func<IDictionary<string, int>, int> Interpret { get; init; }
    public int DoInterpret(IDictionary<string, int> context) => Interpret(context);
    public static PostfixExpression Plus(PostfixExpression left, PostfixExpression right) => new PostfixExpression(interpret: context => left.DoInterpret(context) + right.DoInterpret(context));
    public static PostfixExpression Minus(PostfixExpression left, PostfixExpression right) => new PostfixExpression(interpret: context => left.DoInterpret(context) - right.DoInterpret(context));
    public static PostfixExpression Variable(string c) => new PostfixExpression(interpret: context => context[c]);
}