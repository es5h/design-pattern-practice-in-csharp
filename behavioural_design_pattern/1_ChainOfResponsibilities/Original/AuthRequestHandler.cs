namespace behavioural_design_pattern._1_ChainOfResponsibilities.Original;

public class AuthRequestHandler : RequestHandler
{
    public override void Handler(Request request)
    {
        Console.WriteLine("인증된 회원인가?");
        base.Handler(request);
    }    
}