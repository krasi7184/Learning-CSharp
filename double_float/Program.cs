using System;



class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int s = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int tempk = 0;

        string[] modifiedInput = input.Split(' ');

        int[] arr = new int[modifiedInput.Length];

        for (int i = 0; i < modifiedInput.Length; i++)
        {
            arr[i] = int.Parse(modifiedInput[i]);
        }

        int n = arr.Length;
        int tempn = arr.Length;
        int AllPermutations = 1;

        while (tempn > 0)
        {
            AllPermutations *= tempn;
            tempn--;
        }
        int flag = 1;
        int CounterForSum = 0;
        int tempSum = 0;
        int counterWhile = 0;
        int swaper = 0;
        int counter = n - 1;

        while (counterWhile < AllPermutations)
        {
            counterWhile++;
            while (tempSum <= s)
            {
                if (CounterForSum > arr.Length - 1 || tempk > k) break;
                if (tempSum == s && tempk == k)
                {
                    flag = 0;
                    break;
                }

                tempSum += arr[CounterForSum];
                tempk++;
                CounterForSum++;
            }
            if (flag == 0) break;

            tempSum = 0;
            tempk = 0;
            CounterForSum = 0;

            if (0 == counterWhile % n && counterWhile != AllPermutations)
            {
                swaper = arr[0];
                arr[0] = arr[n - 1];
                arr[n - 1] = swaper;
                while (tempSum <= s)
                {
                    if (CounterForSum > arr.Length - 1 || tempk > k) break;
                    if (tempSum == s && tempk == k)
                    {
                        flag = 0;
                        break;
                    }

                    tempSum += arr[CounterForSum];
                    tempk++;
                    CounterForSum++;
                }
                if (flag == 0) break;
                tempk = 0;
                tempSum = 0;
                CounterForSum = 0;
                counterWhile++;
                counter = n - 1;
            }
            else if (0 == counterWhile % n && counterWhile == AllPermutations) counter = n - 1;
            //gornata proverka e s cel da ne mi izkara exception index out of range

            swaper = arr[counter];
            arr[counter] = arr[counter - 1];
            arr[counter - 1] = swaper;

            counter--;
        }
        if (0 == flag)
        {
            Console.WriteLine("Yes");
        }
        else Console.WriteLine("No");
    }
}




