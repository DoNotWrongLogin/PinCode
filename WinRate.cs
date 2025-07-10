using System;
using Microsoft.Win32.SafeHandles;
using System;

namespace PinCode;

class WinRate
{
    public static void Rate()
    {
        Registr.LoadSaves();
        Console.WriteLine("Введіть нікнейм: ");
        string nick = Console.ReadLine();

        if (Registr.UserHealth.ContainsKey(nick) && Registr.score.ContainsKey(nick))
        {
            double score = Registr.score[nick];
            Console.WriteLine($"🏆 Ваш рахунок: {score}");
     
        }
        else
        {
            Console.WriteLine("❌ Користувача з таким ім'ям не знайдено.");
        }
    }
}
