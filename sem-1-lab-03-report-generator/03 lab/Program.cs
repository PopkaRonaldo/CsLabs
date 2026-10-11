using System;
using System.Globalization;
using System.IO;

public class Program
{
    public static void Main()
    {
        string[] lines = File.ReadAllLines("event_server.log");
        BuildReport(lines);
    }

    public static string BuildReport(string[] lines)
    {
        string bestPlayer = "";
        int kills = -1;
        string date = "";
        string time = "";
        string item = "";
        string winner = "";
        int points = 0;
        bool isEventRunning = false;
        int warnings = 0;
        int errors = 0;
        string utesh = "";

        foreach (string line in lines)
        {
            if (line.Contains("Событие началось:"))
            {
                isEventRunning = true;
                string timeSubstring = line.Substring(0, 19);
                if (DateTime.TryParseExact(timeSubstring, "yyyy-MM-dd HH:mm:ss",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime eventDate))
                {
                    date = eventDate.ToString("dd.MM.yyyy");
                }
            }
            if (isEventRunning == true)
            {
                if (line.Contains("[Warning]"))
                {
                    warnings++;
                }
                if (line.Contains("[Error]"))
                {
                    errors++;
                }
                if (line.Contains("объявлены победителями события"))
                {
                    int messageStart = line.IndexOf("] ") + 2;
                    int winnerEnd = line.IndexOf(" объявлены победителями");
                    winner = line.Substring(messageStart, winnerEnd - messageStart);
                }
                if (line.Contains("[Reward]") && line.Contains(" получили") && line.Contains("очков события"))
                {
                    string clan = line.Substring(line.IndexOf("] ") + 2, line.IndexOf(" получили ") - (line.IndexOf("] ") + 2));
                    if (!clan.Contains("Железные волки"))
                    {
                        string startText = clan + " получили ";
                        int start = line.IndexOf(startText) + startText.Length;
                        int end = line.IndexOf(" очков", start);
                        points = int.Parse(line.Substring(start, end - start));
                    }
                }
                if (line.Contains(winner + " получили ивентовый предмет:"))
                {
                    int strt = line.IndexOf(" получили ивентовый предмет:") + (" получили ивентовый предмет: ").Length;
                    item = line.Substring(strt);
                }
                if (line.Contains("Железные волки получили утешительную награду:"))
                {
                    int strt1 = line.IndexOf("Железные волки получили утешительную награду:") + ("Железные волки получили утешительную награду: ").Length;
                    utesh = line.Substring(strt1, line.IndexOf(" очков события") - strt1);
                }
                if (line.Contains("Игрок ") && line.Contains("победил ") && line.Contains("врагов"))
                {
                    int strt2 = line.IndexOf("Игрок ") + ("Игрок ").Length;
                    int end2 = line.IndexOf("победил ");
                    string player = line.Substring(strt2, end2 - strt2);
                    int strt3 = line.IndexOf("победил ") + ("победил ").Length;
                    int end3 = line.IndexOf("врагов");
                    int playerkills = int.Parse(line.Substring(strt3, end3 - strt3));
                    if (playerkills > kills)
                    {
                        bestPlayer = player;
                        kills = playerkills;
                    }
                }
            }
            if (line.Contains("Событие \"Восстание Ледяного Пламени\" закрыто"))
            {
                break;
            }
        }

        string report = "# Итоги события: Восстание Ледяного Пламени\n" +
                    $"Дата: {date}\n" +
                    $"Победитель: {winner}\n" +
                    $"Очки победителя: {points}\n" +
                    $"Ивентовый предмет: {item}\n" +
                    $"Утешительная награда Железных волков: {utesh} очков\n" +
                    $"Предупреждений во время события: {warnings}\n" +
                    $"Ошибок во время события: {errors}\n" +
                    $"Лучший игрок:{bestPlayer}\n" +
                    $"Колво убийств лучшего игрока:{kills}";
        Console.WriteLine(report);
        return report;
    }
}