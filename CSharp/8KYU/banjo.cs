using System;

public class Kata
{
  public static string AreYouPlayingBanjo(string name)
  {
  string answer;
    if (name.StartsWith("R") || name.StartsWith("r"))
               return  answer = name + " plays banjo";
            else
               return answer = name + " does not play banjo";
  }
}
