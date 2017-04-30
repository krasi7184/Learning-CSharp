using System;

class NumberOfPermutations
{
    static void Main(string[] args)
    {
        //malko e stranen kodut, no ba4ka
        int n = 3;
        int[] arr = new int[] { 1,2,3 };
        int tempn = n;
        int AllPermutations = 1;

        while (tempn > 0)
        {
            AllPermutations *= tempn;
            tempn--;
        }

        int counterWhile = 0;
        int swaper = 0;
        int counter = n - 1;
        
        while (counterWhile < AllPermutations)
        {
            counterWhile++;
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            
            if (0 == counterWhile % n && counterWhile != AllPermutations)
            {
                swaper = arr[0];
                arr[0] = arr[n - 1];
                arr[n - 1] = swaper;
                foreach (var item in arr)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
                
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
        Console.WriteLine("How much? {0}",much);
    }
}

