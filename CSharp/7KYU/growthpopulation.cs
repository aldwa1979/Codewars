using System;

class Arge {
    
    public static int NbYear(int p0, double percent, int aug, int p) {
        int wynik = p0 + (int)(p0 * (percent / 100)) + aug;
        int n = 1;
        if (p > wynik)
        {
        do
        {
            wynik = wynik + (int)(wynik * (percent / 100)) + aug;
            n++;
        }while (p > wynik);
        }
        
        return n;    
    }
}
