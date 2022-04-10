namespace behavioural_design_pattern._1_ChainOfResponsibilities.AfterPattern;

public class Request
{
    public string Body { get; set; }
    public Request(string body)
    {
        Body = body;
    }
}