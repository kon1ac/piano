using System;

class Program
{
    static int[][] octaves = new int[][] {
        new int[] { 200, 300, 400, 500, 600 },
        new int[] { 700, 800, 900, 1000, 1100 },
        new int[] { 1200, 1300, 1400, 1500, 1600 }
    };

    static int currentOctave = 0;

    static void PlaySound(int frequency, int duration)
    {
        Console.Beep(frequency, duration);
    }

    static int[] ChangeOctave(int octave)
    {
        if (octave >= 0 && octave < octaves.Length)
        {
            currentOctave = octave;
            return octaves[octave];
        }
        else
        {
            currentOctave = 0;
            return octaves[0];
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            var key = Console.ReadKey().Key;

            if (key >= ConsoleKey.F1 && key <= ConsoleKey.F3)
            {
                int octave = (int)key - (int)ConsoleKey.F1;
                ChangeOctave(octave);
                continue;
            }

            int frequency;
            int duration;

            switch (key)
            {
                case ConsoleKey.A:
                    frequency = ChangeOctave(currentOctave)[0];
                    duration = 500;
                    break;
                case ConsoleKey.S:
                    frequency = ChangeOctave(currentOctave)[1];
                    duration = 500;
                    break;
                case ConsoleKey.D:
                    frequency = ChangeOctave(currentOctave)[2];
                    duration = 500;
                    break;
                case ConsoleKey.F:
                    frequency = ChangeOctave(currentOctave)[3];
                    duration = 500;
                    break;
                case ConsoleKey.W:
                    frequency = ChangeOctave(currentOctave)[4];
                    duration = 400;
                    break;
                default:
                    continue;
            }

            PlaySound(frequency, duration);
        }
    }
}
