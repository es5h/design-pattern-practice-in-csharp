namespace structural_design_pattern._4_Decorator.AfterPattern;

public class DefaultCommentService : ICommentService
{
    public virtual void AddComment(string comment)
    {
        Console.WriteLine(comment);
    }
}