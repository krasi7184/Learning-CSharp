using System;

class Pages
{
    static void Main()

    {
        uint n = 0;
        int d = 15;
        int DigitsPerPage = 1;
        int counter = 1;
        while (d > 0)
        {
            DigitsPerPage = HowManyDigits(counter);
            counter++;
            n++;
            d -= DigitsPerPage;
        }
        Console.WriteLine(n);
    }
    static int HowManyDigits(int num)
    {
        int n = 0;
        while(num>0)
        {
            n++;
            num /= 10;
        }
        return n;
    }
}



