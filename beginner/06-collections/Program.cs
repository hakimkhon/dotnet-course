internal class Program
{
    private static void Main(string[] args)
    {
        // 1. Ism uchun tekshiruv
        Console.WriteLine("  Task_01");
        ShowName("  Malika  ");
        ShowName("A");
        ShowName("  ");

        // 2. Baholar hisobotini chiqaring
        Console.WriteLine("  Task_02");
        ShowGrades([80, 90, 100]);
        ShowGrades([80, 81]);
        ShowGrades([]);

        // 3. Ko‘rsatiladigan raqamdan indeksga o‘ting
        Console.WriteLine("  Task_03");
        ShowSelectedGrade([80, 90, 100], 1);
        ShowSelectedGrade([80, 90, 100], 3);
        ShowSelectedGrade([80, 90, 100], -1);
        ShowSelectedGrade([], 1);

        // 4. Talabalarni qo‘shing va almashtiring
        Console.WriteLine("  Task_04");
        List<string> talaba = ["Ali", "Vali"];
        talaba.Add("Malika");
        talaba.AddRange("Aziza", "Ali");
        talaba[1] = "Valijon";

        Console.Write($"Count {talaba.Count}; ");
        foreach (string s in talaba)
        {
            Console.Write(s + ", ");
        }
        Console.Write($"\nCapacity {talaba.Capacity}; ");

        // 5. Birinchi mos talabani toping
        Console.WriteLine("  \nTask_05");
        List<string> talabalar1 = new List<string>
        {
            "Ali", "Malika", "Madina"
        };
        string natija = Find(talabalar1);

        if (natija != null)
        {
            Console.WriteLine(natija);
        }
        else
        {
            Console.WriteLine("Talaba topilmadi.");
        }
    }

    static void ShowName(string studentName)
    {
        studentName = studentName.Trim();
        if (studentName.Length != 0)
        {
            Console.WriteLine(
                $"Ism: {studentName}; Length: {studentName.Length}; Birinchi: {studentName[0]}"
            );
        }
        else
            Console.WriteLine("Ism bo'sh.");
    }

    static void ShowGrades(int[] grades)
    {
        int jami = 0;
        double ortacha;

        if (grades.Length >= 1)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"{i + 1}-baho: {grades[i]}; ");
            }

            foreach (int i in grades)
            {
                jami += i;
            }
            ortacha = (double)jami / grades.Length;
            Console.WriteLine($"Jami {jami}; o‘rtacha {ortacha}");
        }
        else
            Console.WriteLine($"Jami {jami}; Baholar hali yo'q.; bo‘lish bajarilmaydi");
    }

    static void ShowSelectedGrade(int[] grades, int gradeNumber)
    {
        if (grades.Length != 0 && grades.Length >= gradeNumber && gradeNumber > 0)
        {
            Console.WriteLine(grades[gradeNumber - 1]);
        }
        else
            Console.WriteLine("Raqam noto'g'ri.");
    }

    static string Find(List<string> ismlar)
    {
        if (ismlar.Count != 0)
        {
            foreach (string item in ismlar)
            {
                if (item.StartsWith("Ma"))
                {
                    return item;
                }
            }
        }
        return "Talaba topilmadi.";
    }
}
