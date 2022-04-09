using structural_design_pattern._1_Adapter.AfterPattern.Adapter;
using structural_design_pattern._1_Adapter.AfterPattern.Security;

namespace structural_design_pattern._1_Adapter.AfterPattern;

public class App
{
    public static void Main(string[] args)
    {
        AccountService accountService = new AccountService();
        IUserDetailService userDetailService = new AccountUserDetailsService(accountService);
        LoginHandler loginHandler = new LoginHandler(userDetailService);
        string login = loginHandler.Login("es5h", "es5h");
        Console.WriteLine(login);
    }
}