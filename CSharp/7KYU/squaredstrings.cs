using System.Linq;
using System;

public class Composing 
{
    
    public static string Compose(string s1, string s2) 
    {
                       string[] str1 = s1.Split('\n').ToArray();
            string[] str2 = s2.Split('\n').ToArray();
            int x = str1.Length;
            int y = x;
            string[] str3 = new string[x];
            string wartosc = null;

            for (int i = 0; i < x; i++)
            {
                char[] char_tab = str1[i].ToCharArray();
                wartosc = null;
                for (int j = 0; j < char_tab.Length; j++)
                {
                    if (j<=i)
                    {
                        wartosc = wartosc + char_tab[j].ToString();
                    }
                    str3[i] = wartosc;
                }
            }

            for (int i = 0; i < x; i++)
            {
                char[] char_tab = str2[i].ToCharArray();
                wartosc = null;
                for (int j = 0; j < char_tab.Length; j++)
                {
                    wartosc = str3[y-1];
                    if (j <= i)
                    {
                        wartosc = wartosc + char_tab[j].ToString();
                    }
                    str3[y-1] = wartosc;
                    
                }
                y--;
            }

            string str4 = null;

            foreach (var item in str3)
            {
                if (str4 == null)
                    str4 = item;
                else
                    str4 = str4 + "\n" + item;
            }
            return str4;
    }
}
