using System;
using System.Linq;

public class Kata
{
  public static int GetAge(string inputString)
  {
           return int.Parse(new string(inputString.First().ToString().ToArray()));
  }
}
