namespace creational_design_pattern._4_BuilderPattern.AfterPattern;

public interface ITourPlanBuilder
{
    ITourPlanBuilder NightsAndDays(int nights, int days);
    ITourPlanBuilder Title(string title);
    ITourPlanBuilder StartDate(DateTime dateTime);
    ITourPlanBuilder WhereToStay(string whereToStay);
    ITourPlanBuilder AddPlan(int day, string plan);
    TourPlan GetPlan();
}