using System;

class JumpJump
{
    static void Main()
    {
        string HowToJump = Console.ReadLine();
        int Position = 0;

        int P = 0;
        while (true)
        {
            if (HowToJump[Position] != '^')
            {
                P = HowToJump[Position] - '0';


                if (0 == P)
                {
                    Console.WriteLine("Too drunk to go on after {0}!", Position);
                    break;
                }
                else if (0 == P % 2)
                {
                    Position += P;
                    if (Position < 0 || Position > HowToJump.Length)
                    {

                        Console.WriteLine("Fell off the dancefloor at {0}!", Position);
                        break;
                    }
                }
                else
                {
                    Position -= P;
                    if (Position < 0 || Position > HowToJump.Length)
                    {
                        Console.WriteLine("Fell off the dancefloor at {0}!", Position);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", Position);
                break;
            }
        }
    }
}

if(start >= 0)
            {
                for (int i = start; i<Line.Length && i >= 0; i += skip)
                {
                    HiddenMessage += Line[i];
                }
            }
            else
            {
                for (int i = Line.Length - start; i<Line.Length && i>=0; i +=skip)
                {
                    HiddenMessage += Line[i];
                }
            }