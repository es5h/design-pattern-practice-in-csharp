namespace structural_design_pattern._1_Adapter.Original.Security;

public interface IUserDetailService
{
    IUserDetails LoadUser(string username);
}