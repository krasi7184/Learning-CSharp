using System;

class HiddenMessage
{
    static void Main()
    {
        string HiddenMessage = null;

        while (true)
        {
            string input = Console.ReadLine();

            if ("end" == input) break;

            int start = int.Parse(input);

            int skip = int.Parse(Console.ReadLine());
            string Line = Console.ReadLine();


            if (start > Line.Length) continue;

            int i = 0;

            if (start >= 0) i = start;
            else i = Line.Length + start;

            for (; i < Line.Length && i >= 0; i += skip)
            {
                HiddenMessage += Line[i];
            }

        }

        Console.WriteLine(HiddenMessage);
    }
}

