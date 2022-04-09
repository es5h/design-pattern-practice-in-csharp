using structural_design_pattern._1_Adapter.AfterPattern.Security;
using IUserDetailService = structural_design_pattern._1_Adapter.AfterPattern.Security.IUserDetailService;

namespace structural_design_pattern._1_Adapter.AfterPattern.WithNoAdapterClass;

public class AccountService : IUserDetailService
{
    public Account FindAccountByUsername(string username)
    {
        Account account = new()
        {
            Name = username,
            Password = username,
            Email = username,
        };

        return account;
    }

    public void CreateNewAccount(Account account)
    {
    }

    public void UpdateAccoutn(Account account)
    {
        
    }

    public IUserDetails LoadUser(string username)
    {
        return FindAccountByUsername(username);
    }
}