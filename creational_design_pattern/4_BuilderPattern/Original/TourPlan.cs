using Lombok.NET;

namespace creational_design_pattern._4_BuilderPattern.Original;

[ToString]
public partial class TourPlan
{
    public string Title { get; set; } = null!;
    public int Nights { get; set; }
    public int Days { get; set; } 
    public DateTime StartDate { get; set; }
    public string WhereToStay { get; set; } = null!;
    public List<DetailPlan> Plans { get; set; } = new List<DetailPlan>();

    public void AddPlan(int day, string plan)
    {
        DetailPlan detailPlan = new (day, plan);
        Plans.Add(detailPlan);
    }
}