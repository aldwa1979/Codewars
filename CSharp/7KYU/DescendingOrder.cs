using System;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    
                string dana2 = num.ToString();

            char[] tab1 = dana2.ToCharArray();

            for (int i = 0; i < tab1.Length; i++)
            {
                for (int j = 0; j < tab1.Length-1; j++)
                {
                    if (tab1[j] < tab1[j + 1])
                    {
                        char a = tab1[j];
                        tab1[j] = tab1[j + 1];
                        tab1[j + 1] = a;
                    }
                }
            }

            string dana3 = new string(tab1);
            int dana4 = Int32.Parse(dana3);
    
return dana4;
  }
}
