namespace behavioural_design_pattern._1_ChainOfResponsibilities.AfterPattern;

public class LoggingRequestHandler : RequestHandler
{
    public override void Handle(Request request)
    {
        Console.WriteLine("logging");
        base.Handle(request);
    }

    public LoggingRequestHandler(RequestHandler nextHandler) : base(nextHandler)
    {
    }
}