using structural_design_pattern._1_Adapter.AfterPattern.Security;

namespace structural_design_pattern._1_Adapter.AfterPattern.WithNoAdapterClass;

public class Account : IUserDetails
{
    public string Name { get; set; }
    public string UserName => Name;
    public string Password { get; set; }
    public string Email { get; set; }
}