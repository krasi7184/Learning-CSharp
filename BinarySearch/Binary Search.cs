using System;

class BinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int x = int.Parse(Console.ReadLine());

        int start = 0;
        int end = n - 1;
        int mid = (n - 1) / 2;
        int output = -1;
        while (start <= end)
        {
            if (arr[mid] == x)
            {
                output = mid;
                break;
            }
            else if (arr[mid] > x) end = mid - 1;
            else start = mid + 1;
            mid = start + (end - start) / 2;
        }
        Console.WriteLine(output);

    }
}
