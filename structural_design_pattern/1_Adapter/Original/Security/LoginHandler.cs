namespace structural_design_pattern._1_Adapter.Original.Security;

public class LoginHandler
{
    private UserDetailService _userDetailService;

    public LoginHandler(UserDetailService userDetailService)
    {
        _userDetailService = userDetailService;
    }

    public string Login(string username, string password)
    {
        UserDetails userDetails = _userDetailService.loadUser(username);
        if (userDetails.Password.Eqauls(password))
        {
            return userDetails.UserName;
        }
        else
        {
            throw new ArgumentException();
        }
    }
}