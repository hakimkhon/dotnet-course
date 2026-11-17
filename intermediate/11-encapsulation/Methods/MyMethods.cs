using System;

namespace Homework11;

public class MyMethods
{
    public void WaterTankTask()
    {
        // Task 01
        var water1 = new WaterTank(100, 40);
        Console.WriteLine(
            water1.Fill(30) ? $"suv {water1.Water}" : $"suv {water1.Water} bo'lib qoldi"
        );
        Console.WriteLine(
            water1.Use(20) ? $"suv {water1.Water}" : $"suv {water1.Water} bo'lib qoldi"
        );
        Console.WriteLine(
            water1.Fill(60) ? $"suv {water1.Water}" : $"suv {water1.Water} bo'lib qoldi"
        );
        Console.WriteLine(
            water1.Use(0) ? $"suv {water1.Water}" : $"suv {water1.Water} bo'lib qoldi"
        );

        var water2 = new WaterTank(50, 10);
        Console.WriteLine($"Birinchi idishning bo‘sh sig‘imi: {water1.GetFreeCapacity()}");
        Console.WriteLine($"Ikkinchi idishdagi suv: {water2.Water}");

        var water3 = new WaterTank(100, 101);
        Console.WriteLine($"Uchinchi idishning bo‘sh sig‘imi: {water3.GetFreeCapacity()}");
    }

    public void StudySessionTask()
    {
        // Task 2
        var lesson1 = new StudySession("C#", 40);
        Console.WriteLine(
            lesson1.RecordMinutes(25)
                ? $"sarflangan vaqt {lesson1.SpentMinutes}"
                : $"sarflangan vaqt {lesson1.SpentMinutes} bo'lib qoldi"
        );
        Console.WriteLine(
            lesson1.RecordMinutes(20)
                ? $"sarflangan vaqt {lesson1.SpentMinutes}"
                : $"sarflangan vaqt {lesson1.SpentMinutes} bo'lib qoldi"
        );
        lesson1.PlannedMinutes = 60;

        // var lesson2 = new StudySession("C#", 60);
        // try
        // {
        //     lesson2.PlannedMinutes = 25;
        // }
        // catch (System.Exception)
        // {

        //     throw;
        // }
        Console.WriteLine(
            lesson1.RecordMinutes(35)
                ? $"sarflangan vaqt {lesson1.SpentMinutes}"
                : $"sarflangan vaqt {lesson1.SpentMinutes} bo'lib qoldi"
        );
    }

    public void GradeBookTask()
    {
        var book1 = new GradeBook("Ali", [70, 80, 90]);
        book1.TryUpdateGrade(1, 0);
        int[] newMassiv = book1.GetGrades();
        newMassiv[1] = 0;
        for (int i = 0; i < newMassiv.Length; i++)
        {
            Console.Write(newMassiv + " ");
        }
        Console.WriteLine($"baholar {book1.Count}");
        // book1.TryUpdateGrade(3, 50);
    }
}
