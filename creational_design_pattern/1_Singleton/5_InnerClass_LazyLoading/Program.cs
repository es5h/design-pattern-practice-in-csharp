﻿namespace creational_design_pattern._1_Singleton._5_InnerClass_LazyLoading
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