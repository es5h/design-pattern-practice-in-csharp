using structural_design_pattern._1_Adapter.AfterPattern.Security;

namespace structural_design_pattern._1_Adapter.AfterPattern.Adapter;

public class AccountUserDetails : IUserDetails
{
    private Account _account;

    public AccountUserDetails(Account account)
    {
        _account = account;
    }

    public string UserName => _account.Name;
    public string Password => _account.Password;
}