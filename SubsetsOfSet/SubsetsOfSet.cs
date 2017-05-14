using System;

class SubsetsOfSet
{
    static void Main()
    {
        int n = 3;
        int[] arr = new int[] { 1, 2, 3 };
        int MaxComb = (1 << n) - 1;
        int comb = 0;


        for (comb = 0; comb <= MaxComb; comb++)
        {
            Console.Write("{");
            for (int bit = 0; bit < n; bit++)
            {
                if (((comb >> bit) & 1) == 1)
                {
                    Console.Write("{0} ", ((comb >> bit) & 1) * arr[bit]);
                }

            }
            Console.WriteLine("}");
        }
    }
}

