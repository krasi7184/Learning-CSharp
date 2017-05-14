using System;

class NumberOfCombinations
{
    static void Main()

    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 1; i <= n; i++)
        {
            arr[i - 1] = i;
        }

        int[] CombArr = new int[k];

        for (int i = 1; i <= k; i++)
        {
            CombArr[i - 1] = i;
        }

        int temp = n;
        int counter = 0;
        int reducer = 0;
        int flag = 0;

        while (true)
        {
            Print(CombArr, n);
            for (int j = CombArr.Length - 1; j >= 0; j--)
            {
                if (CombArr[j] == temp) counter++;
                else break;
                temp--;
            }
            if (counter == CombArr.Length) break;
            while (counter > 0)
            {
                reducer++;
                counter--;
                if (0 == counter)
                {
                    CombArr[CombArr.Length - 1 - reducer]++;
                    for (int p = CombArr.Length - reducer; p < CombArr.Length; p++)
                    {
                        CombArr[p] = CombArr[p - 1] + 1;
                    }
                    flag = 0;
                }
            }
            if (1 == flag) CombArr[CombArr.Length - 1]++;
            reducer = 0;

            flag = 1;
            temp = n;
        }
    }
    static void Print(int[] CombArr, int n)
    {
        for (int i = 0; i < n; i++)
        {
            foreach (var item in CombArr)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            if (CombArr[CombArr.Length - 1] == n) break;
            CombArr[CombArr.Length - 1]++;
        }
    }
}

