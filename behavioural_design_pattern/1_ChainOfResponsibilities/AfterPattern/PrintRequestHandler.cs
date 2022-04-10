namespace behavioural_design_pattern._1_ChainOfResponsibilities.AfterPattern;

public class PrintRequestHandler : RequestHandler
{
    public PrintRequestHandler(RequestHandler nextHandler) : base(nextHandler)
    {
    }

    public override void Handle(Request request)
    {
        Console.WriteLine(request.Body);
        base.Handle(request);
    }
}