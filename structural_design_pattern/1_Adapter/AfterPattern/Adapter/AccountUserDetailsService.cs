using structural_design_pattern._1_Adapter.AfterPattern.Security;

namespace structural_design_pattern._1_Adapter.AfterPattern.Adapter;

public class AccountUserDetailsService : IUserDetailService
{
    private AccountService _accountService;

    public AccountUserDetailsService(AccountService accountService)
    {
        _accountService = accountService;
    }
    
    public IUserDetails LoadUser(string username)
    {
        Account account = _accountService.FindAccountByUsername(username);
        return new AccountUserDetails(account);
    }
}