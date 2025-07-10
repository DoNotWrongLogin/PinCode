using System;
using System.IO;

namespace PinCode;

class Login
{
    public static void SingIn()
    {


        Registr.LoadSaves();
        Console.Write("Введіть логін: ");
        string Name = Console.ReadLine();

        if (Registr.UserHealth.ContainsKey(Name))
        {
            Console.WriteLine("Запуск...");
            GameSet.Game(Name);
        }
        else
        {
            Console.WriteLine("Такого користувача не існує.");
        }

    }
}

       