namespace behavioural_design_pattern._3_Interpreter.AfterPattern;

public interface IPostfixExpression
{
    int Interpret(Dictionary<string, int> context);
}