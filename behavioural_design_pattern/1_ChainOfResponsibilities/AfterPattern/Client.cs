namespace behavioural_design_pattern._1_ChainOfResponsibilities.AfterPattern;

public class Client
{
    private RequestHandler _requestHandler;

    public Client(RequestHandler requestHandler)
    {
        _requestHandler = requestHandler;
    }

    public void DoWork()
    {
        Request request = new ("Hello");
        _requestHandler.Handle(request);
    }
    public static void Main(string[] args)
    {
        RequestHandler chain = new AuthRequestHandler(new LoggingRequestHandler(new PrintRequestHandler(null)));
        Client client = new(chain);
        client.DoWork();
    }
}