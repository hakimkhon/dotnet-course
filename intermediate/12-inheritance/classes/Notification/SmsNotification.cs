namespace Inheritance;
class SmsNotification : Notification
{
    public string? PhoneNumber;
    public SmsNotification(string title, string PhoneNumber) : base(title)
    {
        this.PhoneNumber = PhoneNumber;
    }
}