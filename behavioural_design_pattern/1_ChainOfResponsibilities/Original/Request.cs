namespace behavioural_design_pattern._1_ChainOfResponsibilities.Original;

public class Request
{
    public string Body { get; set; }
    public Request(string body)
    {
        Body = body;
    }
}