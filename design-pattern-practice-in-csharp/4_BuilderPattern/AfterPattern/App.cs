namespace design_pattern_practice_in_csharp_singleton._4_BuilderPattern.AfterPattern;

public class App
{
    public static void Main(string[] args)
    {
        var tourDirector = new TourDirector(new TourPlanBuilder());
        // 이런 Anomaly 도 가능하게 구현 할 수 있을듯
        // var tourDirector = new TourDirector(new TourPlanDetailOrderedBuilder());  
        
        var tourPlan = tourDirector.CanCunTrip();
        var tourPlan1 = tourDirector.LongBeachTrip();

        Console.WriteLine(tourPlan.ToString());
        Console.WriteLine(tourPlan1.ToString());

        /* 아래의 주석에서 작성된 빌더패턴과 유사
        * 빌더패턴의 유의 미해지려면 순서 보장 또는 중간에 컨디션을 줄때 아래 와는 다른 효용가치가 생길듯?
        TourPlan tourPlan = new()
        {
            Title = "China Trip",
            Nights = 2,
            Days = 3,
            StartDate = new DateTime(2022, 04, 08),
            WhereToStay = "Resort"
        };
        */
    }
}