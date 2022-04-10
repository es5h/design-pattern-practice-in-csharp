namespace behavioural_design_pattern._3_Interpreter.AfterPattern;

public class PostfixParser
{
    public static IPostfixExpression Parse(string expression)
    {
        var stack  = new Stack<IPostfixExpression>();
        
        foreach (var c in expression.ToCharArray())
        {
            stack.Push(GetExpression(c, stack));
        }

        return stack.Pop();
    }

    private static IPostfixExpression GetExpression(char c, Stack<IPostfixExpression> stack)
    {
        switch (c)
        {
            case '+':
                return new PlusExpression(stack.Pop(), stack.Pop());
            case '-':
                IPostfixExpression right = stack.Pop();
                IPostfixExpression left = stack.Pop();
                return new MinusExpression(left, right);
            default:
                return new VariableExpression(c.ToString());
        }
    }
    
}