using System;


class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int temp = arr[0];
        int output = 1;

        for (int i = 1; i < n; i++)
        {
            if (arr[i] <= temp)
            {
                output++;
                temp = arr[i];
            }
        }

        Console.WriteLine(output);
    }
}

