using System;


class ConsoleIO
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint p = uint.Parse(Console.ReadLine());
        uint q = uint.Parse(Console.ReadLine());
        uint k = uint.Parse(Console.ReadLine());
        uint save = 1;

        for (int i = (int)(k - 1); i > 0; i--)
        {
            save = (uint)(save + Math.Pow(2, i));
        }

        if (p + k - 1 < 32 && q + k - 1 < 32)
        {
            uint FirstNumbers = (n >> (int)p) & save;
            uint SecondNumbers = (n >> (int)q) & save;
            uint mask = save << (int)q;
            n = ((~mask) & n) | (FirstNumbers<<(int)q);
            mask = save << (int)p;
            n = ((~mask) & n) | (SecondNumbers<<(int)p);
            Console.WriteLine(n);
        }
        else Console.WriteLine("invalid numbers.");
    }
}

