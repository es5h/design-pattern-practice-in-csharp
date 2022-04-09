namespace design_pattern_practice_in_csharp_singleton._4_BuilderPattern.Original;

public class App
{
    public static void Main(string[] args)
    {
        TourPlan tourPlan = new();
        tourPlan.Title = "China Trip";
        tourPlan.Nights = 2;
        tourPlan.Days = 3;
        tourPlan.StartDate = new DateTime(2022, 04, 08);
        tourPlan.WhereToStay = "Resort";
        tourPlan.AddPlan(0, "do something");
        tourPlan.AddPlan(0, "do something2");
        tourPlan.AddPlan(1, "do something3");
        tourPlan.AddPlan(3, "checkout");

        Console.WriteLine(tourPlan.ToString());
    }
}