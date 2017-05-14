using System;

class Feathers
{
    static void Main()
    {
        ulong birds = ulong.Parse(Console.ReadLine());
        ulong feathers = ulong.Parse(Console.ReadLine());

        double average = (double)feathers / (double)birds;
        double result = 0;

        if (birds != 0)
        {
            if (birds % 2 == 0) result = average * 123123123123.0;
            else result = average / 317.0;
        }

        Console.WriteLine("{0:F4}", result);
    }
}

