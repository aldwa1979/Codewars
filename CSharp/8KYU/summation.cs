using System;

public static class Kata 
{
    public static int summation(int num)
    {
      int suma = 0;

            for (int i = 1; i <= num; i++)
            {
                suma = suma + i;
            }
            return suma;
    }
}
