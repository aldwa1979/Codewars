using System;

public class MaxDiffLength 
{
    
    public static int Mxdiflg(string[] a1, string[] a2) 
    {
         if (a1.Length > 0 & a2.Length > 0)
            {

                int x = 0;
                int y = 0;
                int x1_value = 1000;
                int x2_value = 0;
                int y1_value = 1000;
                int y2_value = 0;
                int suma = 0;

                for (int i = 0; i < a1.Length; i++)
                {
                    x = Int32.Parse(a1[i].Length.ToString());
                    if (x1_value > x) x1_value = x;
                }

                for (int i = 0; i < a1.Length; i++)
                {
                    x = Int32.Parse(a1[i].Length.ToString());
                    if (x2_value < x) x2_value = x;
                }

                for (int i = 0; i < a2.Length; i++)
                {
                    y = Int32.Parse(a2[i].Length.ToString());
                    if (y1_value > y) y1_value = y;
                }

                for (int i = 0; i < a2.Length; i++)
                {
                    y = Int32.Parse(a2[i].Length.ToString());
                    if (y2_value < y) y2_value = y;
                }

                int z1 = x1_value - y1_value;
                int z2 = x1_value - y2_value;
                int z3 = x2_value - y1_value;
                int z4 = x2_value - y2_value;

                int suma1 = Math.Abs(z1);
                int suma2 = Math.Abs(z2);
                int suma3 = Math.Abs(z3);
                int suma4 = Math.Abs(z4);

                suma = Math.Max(Math.Max(suma1, suma2), Math.Max(suma3, suma4));
                return suma;
            }
            return -1;
    }
}
