namespace behavioural_design_pattern._1_ChainOfResponsibilities.Original;

public class LoggingRequestHandler : RequestHandler
{
    public override void Handler(Request request)
    {
        Console.WriteLine("logging");
        base.Handler(request);
    }
}