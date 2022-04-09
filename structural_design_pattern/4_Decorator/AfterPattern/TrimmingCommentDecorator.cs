namespace structural_design_pattern._4_Decorator.AfterPattern;

public class TrimmingCommentDecorator : CommentDecorator
{
    public override void AddComment(string comment)
    {
        base.AddComment(Trim(comment));
    }

    private string Trim(string comment)
    {
        return comment.Replace("...", "");
    }

    public TrimmingCommentDecorator(ICommentService commentService) : base(commentService)
    {
    }
}