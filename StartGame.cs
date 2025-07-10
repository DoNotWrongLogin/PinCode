using System;
namespace PinCode;

class StartGame
{
    public static void Start()
    {
        Rules.Rule();
        bool run = true;
        while (run)
        {
            Menu.MainMenu();
            run = Menu.Choise();
        }
    }
}