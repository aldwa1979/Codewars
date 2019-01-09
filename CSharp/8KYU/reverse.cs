using System.Collections.Generic;

public class Kata
{
  public static List<int> ReverseList(List<int> list)
  {
    List<int> list_b = new List<int>(list);
    list_b.Reverse();
    return list_b;
  }
}
