﻿using Lombok.NET;

namespace design_pattern_practice_in_csharp_singleton._4_BuilderPattern.AfterPattern;

[ToString]
public partial class TourPlan
{
    public string Title { get; set; } = null!;
    public int Nights { get; set; }
    public int Days { get; set; } 
    public DateTime StartDate { get; set; }
    public string WhereToStay { get; set; } = null!;
    public List<DetailPlan> Plans { get; set; } = new List<DetailPlan>();

    public TourPlan(string title, int nights, int days, DateTime startDate, string whereToStay, List<DetailPlan> plans)
    {
        Title = title;
        Nights = nights;
        Days = days;
        StartDate = startDate;
        WhereToStay = whereToStay;
        Plans = plans;
    }

    public void AddPlan(int day, string plan)
    {
        DetailPlan detailPlan = new (day, plan);
        Plans.Add(detailPlan);
    }
}