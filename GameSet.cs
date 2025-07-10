using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Permissions;

namespace PinCode;

class GameSet
{
    static string word = "U are gay";
    public static void Game(string playername)

    {
        int health = Registr.UserHealth[playername];
        double score = Registr.score[playername];

        Random random = new Random();
        int randomcode = random.Next(1000, 10000);
        string randomString = randomcode.ToString();
        char[] randomDigits = randomString.ToCharArray();
        bool running = true;

        while (running)
        {
            if (health > 0)
            {
                Console.WriteLine("Введіть ваш варіант коду: ");
                string inpcode = Console.ReadLine();
                if (inpcode.Length != 4)
                {
                    Console.WriteLine();
                    continue;
                }
                if (inpcode == randomString)
                {
                    Console.WriteLine("Вітаю, негіднику! Ти вгадав код!");
                    score += 600;
                    Console.WriteLine("");
                    Console.WriteLine($"🏆Твій рахунок: {score}");
                    Registr.score[playername] = score;
                    Registr.UserHealth[playername] = (short)health;
                    Registr.SaveAllUsers();
                    running = false;
                }
                else
                {
                    bool great = false;
                    for (int i = 0; i < randomDigits.Length; i++)
                    {
                        if (inpcode[i] == randomDigits[i])
                        {
                            Console.WriteLine($"Ти вгадав цифру під номером '{i + 1}' в правильному місці");
                            health -= 2;
                            score += 50;
                            Console.WriteLine($"❤️Здоров'я: {health}");
                            Console.WriteLine($"🏆Рахунок: {score}");
                            great = true;
                        }
                        else if (randomString.Contains(inpcode[i]))
                        {
                            Console.WriteLine($"Ви вгадали цифру під номером '{i + 1}', але вона не на своєму місці ");
                            great = true;
                            score += 10;
                            health -= 5;
                            Console.WriteLine($"❤️Здоров'я: {health} ");
                            Console.WriteLine($"🏆Рахунок: {score}");

                        }
                    }
                    if (!great)
                    {
                        Console.WriteLine("Ти нічого не вгадав...❌");
                        health -= 8;
                        Console.WriteLine($"❤️Твоє здоров'я: {health}");
                        Console.WriteLine($"🏆Твій рахунок: {score}");

                    }
                    if (health <= 0)
                    {
                        Console.WriteLine($"Ви програли. Код був: {randomString}");


                        Registr.score[playername] = score;
                        Registr.UserHealth[playername] = (short)health;
                        Registr.SaveAllUsers();
                        running = false;
                    }// ja pidar

                }


            }


        }

    }
    }

    

