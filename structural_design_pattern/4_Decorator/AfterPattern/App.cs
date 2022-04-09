namespace structural_design_pattern._4_Decorator.AfterPattern;

public class App
{
    private static bool enabledSpamFilter = true;
    private static bool enabledTrimming = true;
    
    public static void Main(string[] args)
    {
        ICommentService commentService = new DefaultCommentService();

        if (enabledSpamFilter)
        {
            commentService = new SpamFilteringCommentDecorator(commentService);
        }

        if (enabledTrimming)
        {
            commentService = new TrimmingCommentDecorator(commentService);
        }

        Client client = new(commentService);
        
        client.WriteComment("squid game");
        client.WriteComment("it's too ... fun");
        client.WriteComment("http://github.com/es5h");
    }
}