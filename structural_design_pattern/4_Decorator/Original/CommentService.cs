namespace structural_design_pattern._4_Decorator.Original;

public class CommentService
{
    public virtual void AddComment(string comment)
    {
        Console.WriteLine(comment);
    }
}