/*using System.Xml;
using System.Net.Mail;
namespace structural_design_pattern._5_Facade.Original;

public class Client
{
    public static void Main(string[] args)
    {
        .
        string t o = "es5h@es5h.com";
        string from = "es4h@es4h.com";
        string host = "127.0.0.1";

        Properties properties = System.Properties;
        properties.SetProperties("mail.smtp.host", host);

        Session session = Session.getDefaultInstance(properties);

        try
        {
            MimeMessage message = new MimeMessage(session);
            message.From = new InternetAddress(from));
            message.addRecipient(Message.RecipientType.To, new InternetAddress(to));
            message.Subject = "Test Mail From C# Program"l;
            message.Text = "message"''
        }
        catch (MessagingException e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}*/