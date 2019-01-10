using System.Linq;
using System;

public class Kata
{
  public static string[] Bald(string x)
  {
     int y = x.Count(p=>p == '/');
     string z = x.Replace("/", "-");
     string[] str = { "Clean!", "Unicorn!", "Homer!", "Careless!", "Hobo!", z};
     string[] str0 = { str[5], str[0] };
     string[] str1 = { str[5], str[1] };
     string[] str2 = { str[5], str[2] };
     string[] str3 = { str[5], str[3] };
     string[] str4 = { str[5], str[4] };
     
            switch(y)
            {
                case 0:
                    return str0;
                    break;
                case 1:
                    return str1;
                    break;
                case 2:
                    return str2;
                    break;
                case 3:
                    return str3;
                    break;
                case 4:
                    goto case 3;
                case 5:
                    goto case 3;
                default:
                    return str4;
                    break;
            }
  }
}
