using System;

class MergeSort
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        MergeRecursion(arr);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }

    }
    static void MergeRecursion(int[] a)
    {
        int n = a.Length;
        if (n < 2) return;
        int mid = n / 2;
        int[] left = new int[mid];
        int[] right = new int[n - mid];
        for (int i = 0; i < mid; i++)
        {
            left[i] = a[i];
        }
        for (int i = 0; i < right.Length; i++)
        {
            right[i] = a[mid];
            mid++;
        }
        MergeRecursion(left);
        MergeRecursion(right);
        Merge(left, right, a);

    }
    static void Merge(int[] left, int[] right, int[] a)
    {
        int nLeft = left.Length;
        int nRight = right.Length;
        int counterL = 0;
        int counterR = 0;
        int counterA = 0;

        while (counterL < nLeft && counterR < nRight)
        {
            if (left[counterL] <= right[counterR])
            {
                a[counterA] = left[counterL];
                counterL++;
            }
            else
            {
                a[counterA] = right[counterR];
                counterR++;
            }
            counterA++;
        }
        while (counterL < nLeft)
        {
            a[counterA] = left[counterL];
            counterA++;
            counterL++;
        }
        while (counterR < nRight)
        {
            a[counterA] = right[counterR];
            counterA++;
            counterR++;
        }
    }
}

