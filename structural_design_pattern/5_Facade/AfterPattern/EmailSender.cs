/*namespace structural_design_pattern._5_Facade.AfterPattern;

public class EmailSender
{
    private EmailSettings _emailSettings;

    public EmailSender(EmailSettings emailSettings)
    {
        _emailSettings = emailSettings;
    }

    public void SendEmail(EmailMessage emailMessage)
    {
        string to = "es5h@es5h.com";
        string from = "es4h@es4h.com";
        string host = "127.0.0.1";

        Properties properties = System.Properties;
        properties.SetProperties("mail.smtp.host", _emailSettings.Host);

        Session session = Session.getDefaultInstance(properties);

        try
        {
            MimeMessage message = new MimeMessage(session);
            message.From = new InternetAddress(emailMessage.From));
            message.addRecipient(Message.RecipientType.To, new InternetAddress(emailMessage.To));
            message.Subject = emailMessage.Subject;
            message.Text = emailMessage.Text;
        }
        catch (MessagingException e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}*/