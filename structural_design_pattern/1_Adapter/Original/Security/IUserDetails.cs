namespace structural_design_pattern._1_Adapter.Original.Security;

public interface IUserDetails
{  
    string UserName { get; }
    string Password { get; }
}