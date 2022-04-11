using System.Threading.Channels;

namespace behavioural_design_pattern._3_Interpreter.AfterPattern_Functional;
using static behavioural_design_pattern._3_Interpreter.AfterPattern_Functional.PostfixExpression;
public static class PostfixParser
{
    public static PostfixExpression Parse(string expression)
    {
        var stack  = new Stack<PostfixExpression>();
        
        foreach (var c in expression.ToCharArray())
        {
            var context = new Dictionary<string, int>()
            {
                {"x", 1},
                {"y", 2},
                {"z", 3},
                {"a", 4},
            };
            stack.Push( GetExpression(c, stack));
        }

        return stack.Pop();
    }

    private static PostfixExpression GetExpression(char c, Stack<PostfixExpression> stack)
    {
        switch (c)
        {
            case '+':
                return Plus(stack.Pop(), stack.Pop());
            case '-':
                PostfixExpression right = stack.Pop();
                PostfixExpression left = stack.Pop();
                return Minus(left, right);;
            default:
                return Variable(c.ToString());
        }
    }
    
}