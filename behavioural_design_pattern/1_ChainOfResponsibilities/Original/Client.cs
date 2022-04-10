using System.Reflection.Metadata.Ecma335;

namespace behavioural_design_pattern._1_ChainOfResponsibilities.Original;

public class Client
{
    public static void Main(string[] args)
    {
        Request request = new Request("무궁화 꽃이 피었습니다.");
        RequestHandler requestHandler = new LoggingRequestHandler();
        requestHandler.Handler(request);
    }
}