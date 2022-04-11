namespace behavioural_design_pattern._3_Interpreter.AfterPattern;


public  interface IPostfixExpression
{
    public int Interpret(Dictionary<string, int> context);
}