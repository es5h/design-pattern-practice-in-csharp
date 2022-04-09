namespace design_pattern_practice_in_csharp_singleton._4_BuilderPattern.AfterPattern;

public class TourPlanBuilder : ITourPlanBuilder
{
    private string _title = null!;
    private int _nights;
    private int _days;
    private DateTime _startDate;
    private string _whereToStay = null!;
    private List<DetailPlan> _plans = null!;
    
    public ITourPlanBuilder NightsAndDays(int nights, int days)
    {
        _nights = nights;
        _days = days;
        return this;
    }

    public ITourPlanBuilder Title(string title)
    {
        _title = title;
        return this;
    }

    public ITourPlanBuilder StartDate(DateTime dateTime)
    {
        _startDate = dateTime;
        return this;
    }

    public ITourPlanBuilder WhereToStay(string whereToStay)
    {
        _whereToStay = whereToStay;
        return this;
    }

    public ITourPlanBuilder AddPlan(int day, string plan)
    {
        if (_plans == null)
        {
            _plans = new List<DetailPlan>();
        }

        _plans.Add(new DetailPlan(day, plan));
        
        return this;
    }

    public TourPlan GetPlan()
    {
        return new(_title, _nights, _days, _startDate, _whereToStay, _plans);
    }
}