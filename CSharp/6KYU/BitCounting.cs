using System;

public class Kata
{
  public static int CountBits(int n)
  {
     var y = Convert.ToString(n, 2).ToCharArray();
     int a = 0;
            foreach (var item in y)
            {
                int d = Convert.ToInt32(item.ToString());
                a += d;
            }
   return a;
  }
}
