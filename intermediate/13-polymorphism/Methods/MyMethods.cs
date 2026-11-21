using Models.Notifications;

public class Mymethods
{
    public void NotificationTask()
    {
        Notification[] notifications =
        {
            new EmailNotification("Aziza", "Hisobingiz tayyor."),
            new SmsNotification("+998901234567", "Kirish kodi: 4812"),
        };

        foreach (Notification notification in notifications)
        {
            notification.Send();
        }

        Payment[] payments =
        {
            new CardPayment(),
            new BankTransferPayment(),
            new WalletPayment(),
        };

        foreach (Payment payment in payments)
        {
            payment.Pay(5000);
        }

    }
 
}
