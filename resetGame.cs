using System;
using System.IO;

namespace PinCode;

class ResetGame
{
    public static void DeleteFile()
    {
        File.Delete("SaveUser.txt");
        Registr.UserHealth.Clear();
        Registr.score.Clear();
        Console.WriteLine("Успішно, ваші дані обнулилися");
    }
}