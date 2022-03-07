namespace Portfolio.Misc;

public interface IEmailSender
{
    void SendEmail(Message message);
}