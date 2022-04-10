namespace behavioural_design_pattern._1_ChainOfResponsibilities.AfterPattern;

public class AuthRequestHandler : RequestHandler
{
    public override void Handle(Request request)
    {
        Console.WriteLine("인증된 회원인가?");
        base.Handle(request);
    }

    public AuthRequestHandler(RequestHandler nextHandler) : base(nextHandler)
    {
    }
}