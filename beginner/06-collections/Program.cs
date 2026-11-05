internal class Program
{
    private static void Main(string[] args)
    {
        // 1. Ism uchun tekshiruv
        System.Console.WriteLine("  Task_01");
        ShowName("  Malika  ");
        ShowName("A");
        ShowName("  ");

        // 2. Baholar hisobotini chiqaring
        System.Console.WriteLine("  Task_02");
        ShowGrades([80, 90, 100]);
        ShowGrades([80, 81]);
        ShowGrades([]);

        // 3. Ko‘rsatiladigan raqamdan indeksga o‘ting
        System.Console.WriteLine("  Task_03");
        ShowSelectedGrade([80, 90, 100], 1);
        ShowSelectedGrade([80, 90, 100], 3);
        ShowSelectedGrade([80, 90, 100], -1);
        ShowSelectedGrade([], 1);

        // 4. Talabalarni qo‘shing va almashtiring
        System.Console.WriteLine("  Task_04");
        List<string> talaba = ["Ali", "Vali"];
        talaba.Add("Malika");
        talaba.AddRange("Aziza", "Ali");
        talaba[1] = "Valijon";

        System.Console.Write($"Count {talaba.Count}; ");
        foreach (string s in talaba)
        {
            Console.Write(s + ", ");
        }
        System.Console.Write($"\nCapacity {talaba.Capacity}; ");

        // 5. Birinchi mos talabani toping
        System.Console.WriteLine("  \nTask_05");
        string harf = "Ma";
        Find(["Ali", "Malika", "Madina"], harf);
        Find(["Ali", "Vali"], harf);
        Find([], harf);


    }

    static void ShowName(string studentName)
    {
        studentName = studentName.Trim();
        if (studentName.Length != 0)
        {
            System.Console.WriteLine($"Ism: {studentName}; Length: {studentName.Length}; Birinchi: {studentName[0]}");
        }
        else System.Console.WriteLine("Ism bo'sh.");
    }

    static void ShowGrades(int[] grades)
    {
        int jami = 0;
        double ortacha;


        if (grades.Length >= 1)
        {

            for (int i = 0; i < grades.Length; i++)
            {
                System.Console.Write($"{i + 1}-baho: {grades[i]}; ");
            }

            foreach (int i in grades)
            {
                jami += i;
            }
            ortacha = (double)jami / grades.Length;
            System.Console.WriteLine($"Jami {jami}; o‘rtacha {ortacha}");

        }
        else System.Console.WriteLine($"Jami {jami}; Baholar hali yo'q.; bo‘lish bajarilmaydi");
    }

    static void ShowSelectedGrade(int[] grades, int gradeNumber)
    {
        if (grades.Length != 0 && grades.Length >= gradeNumber && gradeNumber > 0)
        {
            System.Console.WriteLine(grades[gradeNumber - 1]);
        }
        else System.Console.WriteLine("Raqam noto'g'ri.");
    }

    static void Find(string[] ismlar, string harf)
    {
        if (ismlar.Length != 0)
        {
            foreach (string item in ismlar)
            {
                System.Console.WriteLine(item.StartsWith(harf));
            }
        }
        else System.Console.WriteLine("Talaba topilmadi.");
    }
}