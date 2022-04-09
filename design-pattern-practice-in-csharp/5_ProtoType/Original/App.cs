using System.Threading.Channels;

namespace design_pattern_practice_in_csharp_singleton._5_ProtoType.Original;

public class App
{
    public static void Main(string[] args)
    {
        GithubRepository repository = new();
        repository.User = "es5h";
        repository.Name = "design-pattern-practice";

        GithubIssue githubIssue = new GithubIssue(repository);
        githubIssue.Id = 1;
        githubIssue.Title = "how to use proto-type pattern";

        string url = githubIssue.Url;
        Console.WriteLine(url);

        GithubIssue clone = (GithubIssue) githubIssue.Clone();
        
        Console.WriteLine(clone != githubIssue);
        Console.WriteLine(clone.Equals(githubIssue));
        Console.WriteLine(clone.GetType() == githubIssue.GetType());
    }
}