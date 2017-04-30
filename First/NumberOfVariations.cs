using System;
class NumberOfVariations
{
    static void Main()
    {
        int n = 4;
        int k = 2;
        double AllVariations = Math.Pow(n, k);
        int[] arr = new int[] { 1, 2, 3,4 };
        int[] VarArr = new int[] { 1, 1 };
        int reducer = 0;
        int Counter4 = 0;
        int counter = 0; ;
        int flag = 1;
        for (int i = 0; i < AllVariations; i++)
        {
            Print(VarArr, n);

            if (VarArr[VarArr.Length - 1] == n)
            {
                for (int j = VarArr.Length - 1; j >= 0; j--)
                {
                    if (VarArr[j] == n) Counter4++;
                    else break;
                }
                if (Counter4 == VarArr.Length) break;
                while (Counter4 > 0)
                {
                    VarArr[VarArr.Length - 1 - reducer] = 1;
                    reducer++;
                    Counter4--;
                    if (0 == Counter4)
                    {
                        VarArr[VarArr.Length -1 - reducer]++;
                        flag = 0;
                    }
                }
            }
            if (1 == flag)
            {
                VarArr[VarArr.Length - 1]++;//gre6ka tuk
            }
            reducer = 0;
            flag = 1;
            
            counter = 0;
        }
    }
    static void Print(int[] VarArr, int n)
    {
        for (int i = 0; i < n; i++)
        {
            foreach (var item in VarArr)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            if (VarArr[VarArr.Length - 1] == n) break;
            VarArr[VarArr.Length - 1]++;
        }
    }
}



