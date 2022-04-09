namespace design_pattern_practice_in_csharp_singleton._5_ProtoType.Original;

public class GithubIssue
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Url => $"https://github.com/{_repository.User}/{_repository.Name}/issues/{Id}";

    private readonly GithubRepository _repository;

    public GithubIssue(GithubRepository repository)
    {
        _repository = repository;
    }

    public object Clone()
    {
        return base.MemberwiseClone();
    }

    protected bool Equals(GithubIssue other)
    {
        return _repository.Equals(other._repository) && Id == other.Id && Title == other.Title;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((GithubIssue) obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_repository, Id, Title);
    }
}