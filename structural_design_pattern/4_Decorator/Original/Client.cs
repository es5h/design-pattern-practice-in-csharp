namespace structural_design_pattern._4_Decorator.Original;

public class Client
{
    private CommentService _commentService;

    public Client(CommentService commentService)
    {
        _commentService = commentService;
    }

    private void WriteComment(string comment)
    {
        _commentService.AddComment(comment);
    }

    public static void Main(string[] args)
    {
        Client client = new(new SpamFilteringCommentService());

        Client client2 = new(new SpamFilteringCommentService());
        // SpamFiletering도 하고 싶고, Trimming 도 하고 싶을땐 이런 단일 상속 구조가 불편함. 
        // SpamFiltering 도하고 Trimming 도 하는 다중 상속을 받아야할까? => Decorator
        
        client.WriteComment("squid game");
        client.WriteComment("it's too ... fun");
        client.WriteComment("http://github.com/es5h");
    }
}