class Program
{
    static void Main()
    {
        DateTime dzte = DateTime.Now;
        string formattedDate = ("{date.Day}{date.ToString(dddd)}{date.ToString(MMMM)}{date.Year}");
        Console.WriteLine("Сегодня:" + formattedDate);
        Console.WriteLine("Введите время старта (ЧЧ:ММ:СС):");
        TimeSpan startTime = TimeSpan.Parse(Console.ReadLine());
        Console.WriteLine("Введите время финиша(ЧЧ:ММ:СС):");
        TimeSpan finishTime = TimeSpan.Parse(Console.ReadLine());
        TimeSpan duraction = finishTime - startTime;
        double totalSeconds = duraction.TotalSeconds;
        double distance = 3000;
        double averageSpeed = distance / totalSeconds;
        Console.WriteLine($"Время прохождения дистанции:{totalSeconds}секунд");
        Console.WriteLine($"Средняя скорость:{averageSpeed} м/с");
    }
}
