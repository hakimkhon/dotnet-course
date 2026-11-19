namespace Inheritance;
class EmailNotification : Notification
{
    public string? EmailAddress;

    public EmailNotification(string title, string emailAddress) : base(title)
    {
     this.EmailAddress = emailAddress;   
    }
}