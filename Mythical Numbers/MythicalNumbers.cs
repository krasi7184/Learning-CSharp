using System;


class MythicalNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        int firstDigit = input[0] - '0';
        int secondDigit = input[1] - '0';
        int thirdDigit = input[2] - '0';

        double output = 0;

        if (0 == thirdDigit) output = firstDigit * secondDigit;
        else if (thirdDigit > 0 && thirdDigit <= 5) output = (double)(firstDigit * secondDigit) / (double)thirdDigit;
        else output = (double)(firstDigit + secondDigit) * (double)thirdDigit;

        Console.WriteLine("{0:F2}", output);
    }
}

