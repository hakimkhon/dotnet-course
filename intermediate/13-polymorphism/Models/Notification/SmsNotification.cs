using Models.Notifications;

public class SmsNotification : Notification
{
    public SmsNotification(string recipient, string message) : base(recipient, message)
    {
    }

    public override void Send()
    {
        Console.WriteLine("SMS");
    }
}