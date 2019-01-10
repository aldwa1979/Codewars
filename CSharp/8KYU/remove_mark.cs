public class Kata
{
  public static string Remove(string s, int n)
  {
    for (int i = 0; i < n; i++)
            {
                int y = s.IndexOf("!");
                if (y >= 0) s = s.Remove(y, 1);
                else break;
            }
            return s;
  }
}
