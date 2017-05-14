using System;

class RemoveElementsFromArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int result = 0;

        for (int comb = 1; comb < (1 << n); comb++)
        {
            int previousNum = int.MinValue;
            int tempResult = 0;

            for (int bit = 0; bit < n; bit++)
            {

                if (((comb >> bit) & 1) == 1)
                {
                    if (previousNum > arr[bit])
                    {
                        tempResult = 0;
                        break;
                    }
                    previousNum = arr[bit];
                    tempResult++;
                }

                if (tempResult > result)
                {
                    result = tempResult;
                }
            }

        }
        Console.WriteLine(n - result);
    }

}

