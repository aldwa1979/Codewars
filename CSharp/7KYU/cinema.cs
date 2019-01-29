using System;

public class MovieC {
    
    public static int Movie(int card, int ticket, double perc) {
          
            int i = 0;
            double wartosc_A = 0;
            double wartosc_B = card;

             do
            {
                i++;
                wartosc_A = wartosc_A + ticket;
                var wartosc_B_1 = ticket * Math.Pow(perc, i);
                wartosc_B = wartosc_B + wartosc_B_1;
            }
            while (wartosc_A <= Math.Ceiling(wartosc_B));
            
          return i;
    }
}
