class Program
{
    public static void Main()
    {
        string bestPlayer="";
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


        string[] lines = File.ReadAllLines("event_server.log");
        foreach (string line in lines)
        {
            if (line.Contains("Событие началось:"))
            {
                isEventRunning = true;
                time = line.Substring(0, 10);
                string year = time.Substring(0, 4);
                string month = time.Substring(5, 2);
                string day = time.Substring(8, 2);
                date = day + "." + month + "." + year;
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
                if (line.Contains("[Reward]") &&  line.Contains(" получили") && line.Contains("очков события"))
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
                    int strt = line.IndexOf(" получили ивентовый предмет:")+ (" получили ивентовый предмет:").Length;
                    item = line.Substring(strt);
                }
                if (line.Contains("Железные волки получили утешительную награду:"))
                {
                    int strt1 = line.IndexOf("Железные волки получили утешительную награду:") + ("Железные волки получили утешительную награду: ").Length;
                    utesh = line.Substring(strt1, line.IndexOf(" очков события") - strt1);
                }
                if (line.Contains("Игрок ") && line.Contains("победил ") && line.Contains("врагов"))
                {
                    int strt2 = line.IndexOf("Игрок ")+ ("Игрок ").Length;
                    int end2 = line.IndexOf("победил ");
                    string player = line.Substring(strt2, end2 - strt2);
                    int strt3 = line.IndexOf("победил ")+("победил ").Length;
                    int end3 = line.IndexOf("врагов");
                    int playerkills = int.Parse(line.Substring(strt3, end3 - strt3));
                    if(playerkills>kills)
                    {
                        bestPlayer=player;
                        kills = playerkills;
                    }

                }

            }
            if (line.Contains("Событие \"Восстание Ледяного Пламени\" закрыто"))
            {
                break;
            }
            
        }
        Console.WriteLine("# Итоги события: Восстание Ледяного Пламени");
        Console.WriteLine($"Дата: {date}");
        Console.WriteLine($"Победитель: {winner}");
        Console.WriteLine($"Очки победителя: {points}");
        Console.WriteLine($"Ивентовый предмет: {item}");
        Console.WriteLine($"Утешительная награда Железных волков: {utesh}");
        Console.WriteLine($"Предупреждений во время события: {warnings}");
        Console.WriteLine($"Ошибок во время события:{errors}");
        Console.WriteLine($"Лучший игрок:{bestPlayer}");
        Console.WriteLine($"Колво убийств лучшего игрока:{kills}");
        Console.ReadKey();
    }   
}


