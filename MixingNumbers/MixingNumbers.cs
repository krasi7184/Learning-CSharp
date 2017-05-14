using System;

class MixingNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        int[] mixedNumbers = new int[n - 1];
        int[] subtractedNumbers = new int[n - 1];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            mixedNumbers[i] = (arr[i] % 10) * (arr[i + 1] / 10);
            subtractedNumbers[i] = Math.Abs(arr[i] - arr[i + 1]);
        }

        Console.WriteLine(String.Join(" ", mixedNumbers));
        Console.WriteLine(String.Join(" ", subtractedNumbers));
    }
}

