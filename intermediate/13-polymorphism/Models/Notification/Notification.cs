namespace Models.Notifications;

public class Notification
{
    public string? Recipient {get;}
    public string? Message  {get;}

    public Notification(string recipient, string message)
    {
        this.Recipient = recipient;
        this.Message = message;
    }

    public virtual void Send()
    {
        Console.WriteLine("Bildirishnoma yuborildi.");
    }
}