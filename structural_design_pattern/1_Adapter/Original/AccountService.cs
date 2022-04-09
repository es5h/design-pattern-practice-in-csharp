namespace structural_design_pattern._1_Adapter.Original;

public class AccountService
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
}