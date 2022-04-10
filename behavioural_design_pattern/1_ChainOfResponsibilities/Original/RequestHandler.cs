namespace behavioural_design_pattern._1_ChainOfResponsibilities.Original;

public class RequestHandler
{
    public virtual void Handler(Request request)
    {
        Console.WriteLine(request.Body);
    }
}