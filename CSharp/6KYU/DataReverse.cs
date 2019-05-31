namespace Main{

using System;
using System.Collections.Generic;

public class Kata
{
  public static int[] DataReverse(int[] data)
  {
     List<string> tablo = new List<string>();
     List<int> listaInt = new List<int>();

            string x = null;
            string y = null;

            foreach (var item in data)
            {
                x = x + item;
            }

            for (int i = 0; i < x.Length; i+=8)
            {
                tablo.Add(x.Substring(i, 8));
            }

            tablo.Reverse();

            foreach (var item in tablo)
            {
                y = y + item;
            }

            var a = y.ToCharArray();

            foreach (var item in a)
            {
                listaInt.Add(Convert.ToInt32(item.ToString()));
            }

            return listaInt.ToArray();
    
  }
}
}
