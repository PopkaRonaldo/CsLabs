class Program
{
    public static void Main()
    {
        int s = 0;
        Console.WriteLine("========================Сбор информации о сервере ====================");
        Console.WriteLine("Введите кол-во памяти в гб: ");
        int ram = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во игроков: ");
        int players = int.Parse(Console.ReadLine());
        if (ram>1 && ram*20-players<-5 && ram*20-players>-19)
        {
             s = s+1;
        }
        else if (ram * 20 - players <= -19)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Памяти недостаточно");
            return;
        }
        else if (ram<=0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Памяти недостаточно");
            return;
        }
        Console.Write("Сервер публичный? (true/false): ");
        string publServ = Console.ReadLine();
        if (publServ == "false")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Доступ невозможен тк сервер частный");
            return;
        }
        Console.Write("Сервер защищен поролем? (true/false): ");
        string porol = Console.ReadLine();
        if (porol=="true")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Доступ невозможен тк сервер защищен поролем");
            return;
        }
        Console.WriteLine("========================Итоговое окно====================");
        Console.WriteLine($"Колво памяти: {ram}");
        Console.WriteLine($"Колво людей на сервере: {players}");
        Console.WriteLine($"Сервер публичный?: {publServ}");
        Console.WriteLine($"Сервер защищен поролем?: {porol}");
        Console.WriteLine("==========================================================");
        Console.WriteLine("Вердикт:");
        if (s == 1) Console.WriteLine("Памяти маловато для такого кол-во пользоватей, но не критично");
        else Console.WriteLine("Сервер полностью исправен и готов к запуску");
    }

}