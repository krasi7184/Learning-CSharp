using System;

class Program
{
    static void Main()
    {
        int n = 5;// int.Parse(Console.ReadLine());
        int k = 3;// int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i + 1;
        }

        Combinations(arr, new int[k], 0, 0);
    }
    static void Combinations(int[] arr , int[] numbers, int index, int start)
    {
        int flag = 0;
        if(index == numbers.Length)
        {
            Console.WriteLine(String.Join(" ", numbers));
            return;
        }

        for (int i = start; i < arr.Length; i++)
        {
            
            numbers[index] = arr[i];
            Combinations(arr, numbers, index + 1, start + 1);
        }
    }
}

