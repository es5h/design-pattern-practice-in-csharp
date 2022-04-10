namespace structural_design_pattern._5_Facade.AfterPattern;

public class Client
{
    public static void Main(string[] args)
    {
        EmailSettings emailSettings = new();
        emailSettings.Host = "127.0.0.1";
        EmailSender emailSender = new EmailSender(emailSettings);
        EmailMessage emailMessage = new();
        emailMessage.To = "es5h";
        emailMessage.From = "es6h";
        emailMessage.Subject = "hi";
        emailMessage.Text = "hi from seoul";
        emailSender.SendEmail(emailMessage);

    }
}