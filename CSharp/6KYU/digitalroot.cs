using System;

public class Number
{
  public int DigitalRoot(long n)
  {
    int suma = 0;

   char[] y;
   y = n.ToString().ToCharArray();
    
    do
            {
                if (y.Length >1)
                {
                    int wynik = 0;
                   
                    for (int i = 0; i < y.Length; i++)
                    {
                        int z = Int16.Parse(y.GetValue(i).ToString());
                        wynik = wynik + z;
                    }
                    suma = wynik;
                    
                    y = wynik.ToString().ToCharArray();
                }
            }
            while (y.Length > 1);
            
            return suma;
    
  }
}
