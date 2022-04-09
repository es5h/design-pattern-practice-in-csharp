namespace structural_design_pattern._1_Adapter.AfterPattern.Security;

public interface IUserDetailService
{
    IUserDetails LoadUser(string username);
}