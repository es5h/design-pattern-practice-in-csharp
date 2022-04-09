namespace creational_design_pattern._4_BuilderPattern.AfterPattern;

public class DetailPlan
{
    public int Day { get; set; }
    public string Plan { get; set; }
    
    public DetailPlan(int day, string plan)
    {
        Day = day;
        Plan = plan;
    }
}