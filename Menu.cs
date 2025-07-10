using System;
namespace PinCode;

class Menu
{
    public static void MainMenu()
    {
        Console.WriteLine("");
        Console.WriteLine(" ==Меню== ");
        Console.WriteLine("");
        Console.WriteLine("1.Починай гру");
        Console.WriteLine("2.Почни наново");
        Console.WriteLine("3.який в мене рекорд перемог");
        Console.WriteLine("4.Створи мені аккаунт");
        Console.WriteLine("5.Закінчуй гру");
        Console.WriteLine("6. Нагадай правила.");
    }
    public static bool Choise()

    {
        while (true)
        {
            Console.WriteLine("");
            Console.Write("Виберіть взаємодію: ");
            string choiseIndex = Console.ReadLine();

            if (choiseIndex == "1")
            {
                Login.SingIn();

                return true;
            }
            else if (choiseIndex == "2")
            {
                ResetGame.DeleteFile();
                return true;
            }
            else if (choiseIndex == "6")
            {
                Console.WriteLine("Ну що ж... Напам'ятаю тобі правила");
                Console.WriteLine("");
                Rules.Rule();
            }
            else if (choiseIndex == "3")
            {
                WinRate.Rate();
                return true;
            }
            else if (choiseIndex == "4")
            {
                Registr.SingUp();
            }
            else if (choiseIndex == "5")
            {
                Console.WriteLine("");
                Console.WriteLine("Вихід з ігри...");
                return false;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Такої взаємодії не існує");

            }

        }
    }
}