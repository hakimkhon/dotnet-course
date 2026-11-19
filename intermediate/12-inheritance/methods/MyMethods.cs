namespace Inheritance;

class MyMethods
{
    public void PersonTask()
    {
        var student = new Student(name: "Ali", course: "C#");
        student.Introduce();
    }
    public void EmployeeTask()
    {
        var devoloper = new Developer("Malika", "IT", "C#");
        devoloper.ShowInfo();
        // devoloper.ShowInfoDeveloper();

        var designer = new Designer("Jasur", "Design", "Figma");
        designer.ShowInfo();
        // designer.ShowInfoDeveloper();

    }

    public void DeviseTask()
    {
        var phone = new Phone("Pixel");
        phone.ShowModel();
        phone.ShowPhoneModel();
    }

    public void NotificationTask()
    {
        var emailNotification = new EmailNotification("Xush kelibsiz", "ali@example.com");
        var smsNotification = new SmsNotification("Tasdiqlash kodi", "+998901234567");

        // if (is EmailNotification emailNotification.EmailAddress)
        {
            
        }

    }
}
