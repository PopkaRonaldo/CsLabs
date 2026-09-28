namespace ConsoleApp600;


class Program
    
{
    public static void Main()
    {
        Console.WriteLine("Укажите номер сервера для статистики(123456789101112 или 213456789101112):");
        long nomerServ = long.Parse(Console.ReadLine());
        
            if (nomerServ== 123456789101112)
            {
                byte klvLudeyZaregDo = 156;
                byte onlineNowDo = 98;
                byte zababnenuhDo = 30;
                byte srednyPingDo = 76;
                double skorostSetiDo = 234.78;
                double vremaRabotuMinutDo = 48.30;
                Console.WriteLine($"====================Сбор информации о сервере {nomerServ} после его обновления===================\n");
                Console.WriteLine("Кол-во зарегестрированных людей на данный момент(больше или равно 156 и меньше 256(т.к. сервер расчитан только на 255 человек маскимум)):");
                byte klvLudeyZaregPosle = byte.Parse(Console.ReadLine());
                if (klvLudeyZaregPosle<156)
                {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Кол-во зарегестрированых людей не могло упасть");
                    return;
                }
                Console.WriteLine("Кол-во людей онлайн:");
                byte OnlineNowPosle = byte.Parse(Console.ReadLine());
                Console.WriteLine("Кол-во людей забанены на сервере(больше или равно 30):");
                byte zababnenuhPosle = byte.Parse(Console.ReadLine());
                if (zababnenuhPosle < 30)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Кол-во забаненых людей не могло упасть");
                    return;
                }

                Console.WriteLine("Средний пинг:");
                byte srednyPingPosle = byte.Parse(Console.ReadLine());
              
                Console.WriteLine("Скорость сети:");
                double skorostSetiPosle = double.Parse(Console.ReadLine());

                Console.WriteLine("Время работы сервера(через запятую):");
                double vremaRabotuChasuAndMinutPosle = double.Parse(Console.ReadLine());

                Console.WriteLine("====================Cводная таблица изменений====================");
                Console.WriteLine($"Количесто зарегестрированных пользователей: {klvLudeyZaregPosle}");
                Console.WriteLine($"Cейчас онлайн: {OnlineNowPosle}");
                Console.WriteLine($"Количесто забаненных пользователей: {zababnenuhPosle}");
                Console.WriteLine($"Средний пинг: {srednyPingPosle}");
                Console.WriteLine($"Скорость сети: {skorostSetiPosle}");
                Console.WriteLine($"Время работы сервера: {vremaRabotuChasuAndMinutPosle}");
                Console.WriteLine("================================================================");
                Console.WriteLine("Подведем итог:");
                if (klvLudeyZaregPosle> klvLudeyZaregDo)
                {
                Console.WriteLine("Неплохой результат! Количество игроков выросло на " + (klvLudeyZaregPosle - klvLudeyZaregDo));
                }


                if (OnlineNowPosle > onlineNowDo)
                {
                    Console.WriteLine("Супер! Онлайн вырос на " + (OnlineNowPosle - onlineNowDo));
                }
                else
                {
                    Console.WriteLine("Онлайн еще вырастет. Время раставит все по местам");
                }
                

                if (srednyPingPosle < srednyPingDo)
                {
                    Console.WriteLine("Поздравляем! Пинг уменьшился на " + (srednyPingDo - srednyPingPosle));
                }
                else
                {
                    Console.WriteLine("Пинг вырос(");
                }
            

                if (skorostSetiPosle > skorostSetiDo)
                {
                Console.WriteLine("Отлично! Скорость сети выросла");
                }
                else
                {
                    Console.WriteLine("Скорость сети не супер");
                }

            }
            else if(nomerServ == 213456789101112)
            {
                byte klvLudeyZaregDo = 196;
                byte onlineNowDo = 116;
                byte zababnenuhDo = 49;
                byte srednyPingDo = 82;
                double skorostSetiDo = 210.36;
                double vremaRabotuMinutDo = 47.15;
            Console.WriteLine($"====================Сбор информации о сервере {nomerServ} после его обновления===================\n");
            Console.WriteLine("Кол-во зарегестрированных людей на данный момент(больше или равно 196 и меньше 256(т.к. сервер расчитан только на 255 человек маскимум) ):");
            byte klvLudeyZaregPosle = byte.Parse(Console.ReadLine());
            if (klvLudeyZaregPosle < 196)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Кол-во зарегестрированых людей не могло упасть");
                return;
            }
            Console.WriteLine("Кол-во людей онлайн:");
            byte OnlineNowPosle = byte.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во людей забанены на сервере(больше или равно 49):");
            byte zababnenuhPosle = byte.Parse(Console.ReadLine());
            if (zababnenuhPosle < 49)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Кол-во забаненых людей не могло упасть");
                return;
            }

            Console.WriteLine("Средний пинг:");
            byte srednyPingPosle = byte.Parse(Console.ReadLine());

            Console.WriteLine("Скорость сети:");
            double skorostSetiPosle = double.Parse(Console.ReadLine());

            Console.WriteLine("Время работы сервера(через запятую):");
            double vremaRabotuChasuAndMinutPosle = double.Parse(Console.ReadLine());

            Console.WriteLine("====================Cводная таблица изменений====================");
            Console.WriteLine($"Количесто зарегестрированных пользователей: {klvLudeyZaregPosle}");
            Console.WriteLine($"Cейчас онлайн: {OnlineNowPosle}");
            Console.WriteLine($"Количесто забаненных пользователей: {zababnenuhPosle}");
            Console.WriteLine($"Средний пинг: {srednyPingPosle}");
            Console.WriteLine($"Скорость сети: {skorostSetiPosle}");
            Console.WriteLine($"Время работы сервера: {vremaRabotuChasuAndMinutPosle}");
            Console.WriteLine("================================================================");
            Console.WriteLine("Подведем итог:");
            if (klvLudeyZaregPosle > klvLudeyZaregDo)
            {
                Console.WriteLine("Неплохой результат! Количество игроков выросло на " + (klvLudeyZaregPosle - klvLudeyZaregDo));
            }


            if (OnlineNowPosle > onlineNowDo)
            {
                Console.WriteLine("Супер! Онлайн вырос на " + (OnlineNowPosle - onlineNowDo));
            }
            else
            {
                Console.WriteLine("Онлайн еще вырастет. Время раставит все по местам");
            }


            if (srednyPingPosle < srednyPingDo)
            {
                Console.WriteLine("Поздравляем! Пинг уменьшился на " + (srednyPingDo - srednyPingPosle));
            }
            else
            {
                Console.WriteLine("Пинг вырос(");
            }


            if (skorostSetiPosle > skorostSetiDo)
            {
                Console.WriteLine("Отлично! Скорость сети выросла");
            }
            else
            {
                Console.WriteLine("Скорость сети не супер");
            }



        }
        else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ОШИБКА: Сервер с таким ID не найден в базе данных!");
                int s = 67;
            }
        
        
    }
}
