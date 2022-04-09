namespace design_pattern_practice_in_csharp._5_ProtoType.Original;

public class App
{
    public static void Main(string[] args)
    {
        GithubRepository repository = new()
        {
            User = "es5h",
            Name = "design-pattern-practice"
        };

        GithubIssue githubIssue = new GithubIssue(repository)
        {
            Id = 1,
            Title = "how to use proto-type pattern"
        };

        string url = githubIssue.Url;
        Console.WriteLine(url);

        GithubIssue clone = (GithubIssue) githubIssue.Clone();
        
        Console.WriteLine(clone != githubIssue);
        Console.WriteLine(clone.Equals(githubIssue));
        Console.WriteLine(clone.GetType() == githubIssue.GetType());
    }
}