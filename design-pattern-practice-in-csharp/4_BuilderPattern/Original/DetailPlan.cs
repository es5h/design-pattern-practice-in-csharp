namespace design_pattern_practice_in_csharp_singleton._4_BuilderPattern.Original;

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