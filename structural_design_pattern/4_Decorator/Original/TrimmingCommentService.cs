namespace structural_design_pattern._4_Decorator.Original;

public class TrimmingCommentService : CommentService
{
    public override void AddComment(string comment)
    {
        base.AddComment(Trim(comment));
    }

    private string Trim(string comment)
    {
        return comment.Replace("...", "");
    }
}