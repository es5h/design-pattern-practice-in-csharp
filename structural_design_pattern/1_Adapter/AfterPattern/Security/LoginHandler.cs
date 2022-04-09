namespace structural_design_pattern._1_Adapter.AfterPattern.Security;

public class LoginHandler
{
    private IUserDetailService _userDetailService;

    public LoginHandler(IUserDetailService userDetailService)
    {
        _userDetailService = userDetailService;
    }

    public string Login(string username, string password)
    {
        IUserDetails userDetails = _userDetailService.LoadUser(username);
        if (userDetails.Password.Equals(password))
        {
            return userDetails.UserName;
        }
        else
        {
            throw new ArgumentException();
        }
    }
}