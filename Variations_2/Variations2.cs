using System;

class program
{
    static void Main()
    {
        int n = 4;// int.Parse(Console.ReadLine());
        int k = 3;// int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i + 1;
        }


        variations(arr, new int[k], 0);
    }
    static void variations(int[] arr, int[] numbers, int index)
    {
        if (index == numbers.Length)
        {
            Console.WriteLine(string.Join(" ", numbers));
            return;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            numbers[index] = arr[i];
            variations(arr, numbers, index + 1);
        }
    }
}


