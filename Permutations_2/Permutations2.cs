using System;

class Permutations2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i + 1;
        }

        Permutations(arr, 0);
    }
    static void Permutations(int[] arr, int index)
    {
        if (index == arr.Length - 1)
        {
            Console.WriteLine(String.Join(" ", arr));
        }
        else
        {
            for (int i = index; i < arr.Length; i++)
            {
                swap(i, index, arr);
                Permutations(arr, index + 1);
                swap(i, index, arr);
            }
        }
    }
    static void swap(int a, int b, int[] arr)
    {
        int temp = 0;
        temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
}

