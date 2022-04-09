namespace structural_design_pattern._4_Decorator.AfterPattern;

public class SpamFilteringCommentDecorator : CommentDecorator
{
    public override void AddComment(string comment)
    {
        bool isSpam = IsSpam(comment);
        if (!isSpam)
        {
            base.AddComment(comment);
        }
    }

    private bool IsSpam(string comment)
    {
        return comment.Contains("http");
    }

    public SpamFilteringCommentDecorator(ICommentService commentService) : base(commentService)
    {
    }

}