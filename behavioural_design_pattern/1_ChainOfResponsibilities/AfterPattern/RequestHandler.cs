namespace behavioural_design_pattern._1_ChainOfResponsibilities.AfterPattern;

public abstract class RequestHandler
{
    private RequestHandler _nextHandler;

    protected RequestHandler(RequestHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public virtual void Handle(Request request)
    {
        if (_nextHandler != null)
        {
            _nextHandler.Handle(request);
        }
    }
}