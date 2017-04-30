using System;

class QuickSort
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int start = 0;
        int end = n - 1;
        QuickSortAlgorithm(arr, start, end);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    static void QuickSortAlgorithm(int[] arr, int start, int end)
    {
        if (start < end)
        {
            int pIndex = Partition(arr, start, end);
            QuickSortAlgorithm(arr, start, pIndex - 1);
            QuickSortAlgorithm(arr, pIndex + 1, end);
        }
    }
    static int Partition(int[] arr, int start, int end)
    {
        int pivot = arr[end];
        int pIndex = start;
        int temp = 0;
        for (int i = start; i < end; i++)
        {
            if (arr[i] <= pivot)
            {
                temp = arr[i];
                arr[i] = arr[pIndex];
                arr[pIndex] = temp;
                pIndex++;
            }
        }
        temp = arr[pIndex];
        arr[pIndex] = arr[end];
        arr[end] = temp;
        return pIndex;
    }
}

