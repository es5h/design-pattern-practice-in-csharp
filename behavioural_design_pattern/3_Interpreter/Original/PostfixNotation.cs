using System.Threading.Channels;

namespace behavioural_design_pattern._3_Interpreter.Original;

public class PostfixNotation
{
    private readonly string _expression;

    public PostfixNotation(string expression)
    {
        _expression = expression;
    }

    public static void Main(string[] args)
    {
        PostfixNotation postfixNotation = new("123+-");
        postfixNotation.Calculate();
    }

    private void Calculate()
    {
        var numbers = new Stack<int>();
        foreach (var c in _expression.ToCharArray())
        {
            switch (c)
            {
                case '+':
                    numbers.Push(numbers.Pop()+numbers.Pop());
                        
                    break;
                case '-' :
                    int right = numbers.Pop();
                    int left = numbers.Pop();
                    numbers.Push(left - right);
                    break;
                default:
                    numbers.Push(int.Parse(c.ToString()));
                    break;
            }
        }

        Console.WriteLine(numbers.Pop());
    }
}