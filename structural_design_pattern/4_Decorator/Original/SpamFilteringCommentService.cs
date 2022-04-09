namespace structural_design_pattern._4_Decorator.Original;

public class SpamFilteringCommentService : CommentService
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
}