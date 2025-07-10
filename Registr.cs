

using System;
using System.IO;
using System.Collections.Generic;

namespace PinCode;

using System;
using System.IO;
using System.Collections.Generic;


class Registr
{
  public static Dictionary<string, short> UserHealth = new Dictionary<string, short>();
  public static Dictionary<string, double> score = new Dictionary<string, double>();

  public static void SingUp()
  {
    Console.Write("Введіть нік: ");
    string name = Console.ReadLine();

    if (UserHealth.ContainsKey(name))
    {
      Console.WriteLine("Такий користувач вже існує.");
    }
    else
    {
      UserHealth[name] = 100;
      score[name] = 0;  // новий гравець із початковим рахунком 0
      Console.WriteLine("\n✅ Акаунт створено");

      SaveAllUsers();
    }
  }

  public static void SaveAllUsers()
  {
    using (StreamWriter writer = new StreamWriter("SaveUser.txt"))
    {
      foreach (var user in UserHealth)
      {
        double userScore = score.ContainsKey(user.Key) ? score[user.Key] : 0;
        writer.WriteLine($"{user.Key}:{user.Value}:{userScore}");
      }
    }

    Console.WriteLine("💾 Дані збережено.");
  }

  public static void LoadSaves()
  {
    if (File.Exists("SaveUser.txt"))
    {
      string[] lines = File.ReadAllLines("SaveUser.txt");
      foreach (string line in lines)
      {
        string[] parts = line.Split(':');
        if (parts.Length == 3)
        {
          string name = parts[0];
          if (short.TryParse(parts[1], out short hp) &&
              double.TryParse(parts[2], out double userScore))
          {
            UserHealth[name] = hp;
            score[name] = userScore;
          }
        }
      }
    }
  }

  public static double GetScore(string playername)
  {
    return score.ContainsKey(playername) ? score[playername] : 0;
  }

  public static void SetScore(string playername, double newScore)
  {
    score[playername] = newScore;
  }
}

    
