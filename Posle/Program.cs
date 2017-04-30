using System;


class Program
{
    static void Main()
    {
        int head = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int BestCount = 0;
        int CurrentCount = 0;
        int BestComb = 0;

        for (int i = 0; i < n; i++)
        {
            int comb = int.Parse(Console.ReadLine());
            if(0 == (head & comb))
            {
                for (int j = 0; j < 32 && (comb>>j) != 0; j++)
                {
                    CurrentCount += (comb >> j) & 1;
                }
                if (CurrentCount > BestCount)
                {
                    BestCount = CurrentCount;
                    BestComb = comb;
                }
                CurrentCount = 0;
            }
        }
        Console.WriteLine(BestComb);
    }
}

