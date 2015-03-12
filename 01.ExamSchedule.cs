using System;
using System.Globalization;
using System.Threading;
class ExamSchedule
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        string startHour = Console.ReadLine();
        string startMinutes = Console.ReadLine();
        string pmOram = Console.ReadLine();
        string durationHour = Console.ReadLine();
        string durationMinutes = Console.ReadLine();
        string startTime = startHour + ":" + startMinutes + " " + pmOram;
        string durationTime = durationHour + ":" + durationMinutes;
        DateTime start = DateTime.Parse(startTime);
        TimeSpan duration = TimeSpan.Parse(durationTime);
        DateTime final = start + duration;
        Console.WriteLine(final.ToString(@"hh:mm:tt"));
    }
}
