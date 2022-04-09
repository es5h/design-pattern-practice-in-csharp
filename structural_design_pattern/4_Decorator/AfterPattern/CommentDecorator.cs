namespace structural_design_pattern._4_Decorator.AfterPattern;

public class CommentDecorator : DefaultCommentService
{
    private readonly ICommentService _commentService;

    public CommentDecorator(ICommentService commentService)
    {
        _commentService = commentService;
    }

    public override void AddComment(string comment)
    {
        _commentService.AddComment(comment);
    }
}