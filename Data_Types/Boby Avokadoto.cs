using System;

class Program
{
    static void Main()
    {

        int head = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int TempInput = 0;
        string TempInputBit = null;
        string BitHead = Convert.ToString(head, 2);
        int BestCombTemp = 0;
        int BestComb = 0;
        int Remember = 0;
        string ivan = null;

        for (int i = 0; i < n; i++)
        {

            TempInput = int.Parse(Console.ReadLine());
            ivan = Convert.ToString(TempInput, 2);
            TempInputBit = ivan.PadLeft(BitHead.Length, '0');
            BestCombTemp = Iterator(BitHead, TempInputBit);
            if (BestComb < BestCombTemp)
            {
                BestComb = BestCombTemp;
                Remember = TempInput;
            }

        }
        Console.WriteLine(Remember);
    }
    static int Iterator(string BitHead, string TempInputBit)
    {
        int BestCombTemp = 0;
        for (int i = 0; i < BitHead.Length; i++)
        {
            if ('1' == BitHead[i])
            {
                if (BitHead[i] == TempInputBit[i])
                {
                    return 0;
                }
            }
            if ('0' == BitHead[i] && '1' == TempInputBit[i]) BestCombTemp++;
        }
        return BestCombTemp;
    }
}
