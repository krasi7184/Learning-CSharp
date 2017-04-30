using System;

class SieveOfEratosthenes
{
    static void Main(string[] args)
    {
        int n = 30;
        int[] Primes = new int[n + 1];
        for (int i = 0; i <= n; i++)
        {
            Primes[i] = 1;
        }
        Primes[0] = 0;
        Primes[1] = 0;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (1 == Primes[i])
            {
                for (int j = 2; i * j <= n; j++)
                {
                    Primes[i * j] = 0;
                }
            }
        }
        for (int i = 2; i <= n; i++)
        {
            if (1 == Primes[i])
            {
                Console.WriteLine(i);
            }
        }
    }
}

