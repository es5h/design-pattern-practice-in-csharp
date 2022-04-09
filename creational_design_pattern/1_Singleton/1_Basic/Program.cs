namespace design_pattern_practice_in_csharp._1_Singleton._1_Basic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Settings settings1 = Settings.Instance;
            Settings settings2 = Settings.Instance;

            Console.WriteLine(settings1 == settings2);
        }
    }
}

