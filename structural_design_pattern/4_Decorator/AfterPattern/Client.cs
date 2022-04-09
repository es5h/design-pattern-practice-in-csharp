using structural_design_pattern._4_Decorator.Original;

namespace structural_design_pattern._4_Decorator.AfterPattern;

public class Client
{
    private ICommentService _commentService;

    public Client(ICommentService commentService)
    {
        _commentService = commentService;
    }

    public void WriteComment(string comment)
    {
        _commentService.AddComment(comment);
    }
}