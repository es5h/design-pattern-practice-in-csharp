namespace design_pattern_practice_in_csharp._4_BuilderPattern.AfterPattern;

public class TourDirector
{
    private readonly TourPlanBuilder _tourPlanBuilder;

    public TourDirector(TourPlanBuilder tourPlanBuilder)
    {
        _tourPlanBuilder = tourPlanBuilder;
    }

    public TourPlan LongBeachTrip()
    {
        return _tourPlanBuilder.Title("Longbeach trip")
            .StartDate(new DateTime(2022, 4, 5))
            .GetPlan();
    }
    
    public TourPlan CanCunTrip()
    {
        return _tourPlanBuilder.Title("Cancun Trip")
            .NightsAndDays(2, 3)
            .StartDate(new DateTime(2020, 1, 3))
            .WhereToStay("resort")
            .AddPlan(0, "just enjoy")
            .AddPlan(1, "go to sleep")
            .GetPlan();
    }
    
    
}