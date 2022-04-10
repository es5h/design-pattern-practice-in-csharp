namespace behavioural_design_pattern._3_Interpreter.AfterPattern;

public class App
{
    public static void Main(string[] args)
    {
        IPostfixExpression expression = PostfixParser.Parse("xyz+-a+");
        int result = expression.Interpret(new Dictionary<string, int>()
        {
            {"x", 1},
            {"y", 2},
            {"z", 3},
            {"a", 4},
        });
        Console.WriteLine(result);
    }
   
}