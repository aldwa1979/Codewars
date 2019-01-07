using System;

public static class Kata
    {
        public static string AddBinary(int a, int b)
        {
            string x = Convert.ToString(a + b, 2);
            return x;
        }
}
