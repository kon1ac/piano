using System.Text;

namespace Pianino
{
    internal class Program
    {
        static void Main()
        {
            ChangeOfOctaves();
        }
        static void ChangeOfOctaves()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Переклать октавы - от F2 и до F7");
            Console.WriteLine("Что бы выйти - тыкни Enter");
            ConsoleKeyInfo OctaveButton = Console.ReadKey();
            int[] octave = smenaOctaves(1);

            if (OctaveButton.Key == ConsoleKey.F1)
            {
                octave = smenaOctaves(1);
                Octave(octave, "1 октава");
            }
            if (OctaveButton.Key == ConsoleKey.F2)
            {
                octave = smenaOctaves(2);
                Octave(octave, "2 октава");
            }
            if (OctaveButton.Key == ConsoleKey.F3)
            {
                octave = smenaOctaves(3);
                Octave(octave, "3 октава");
            }

            if (OctaveButton.Key == ConsoleKey.F4)
            {
                octave = smenaOctaves(4);
                Octave(octave, "4 октава");
            }
            if (OctaveButton.Key == ConsoleKey.F5)
            {
                octave = smenaOctaves(5);
                Octave(octave, "5 октава");
            }
            if (OctaveButton.Key == ConsoleKey.F6)
            {
                octave = smenaOctaves(6);
                Octave(octave, "6 октава");
            }
            if (OctaveButton.Key == ConsoleKey.F7)
            {
                octave = smenaOctaves(3);
                Octave(octave, "7 октава");
            }
            if (OctaveButton.Key == ConsoleKey.F8)
            {
                octave = smenaOctaves(8);
                Octave(octave, "8 октава");
            }
            if (OctaveButton.Key == ConsoleKey.F9)
            {
                octave = smenaOctaves(9);
                Octave(octave, "9 октава");
            }
            if (OctaveButton.Key == ConsoleKey.Enter) Environment.Exit(1);
        }
        static int[] Octave(int[] passedOctave, string textOctave)
        {
            Console.WriteLine(textOctave);
            ConsoleKeyInfo Button = Console.ReadKey();
            while (true)
            {
                if (Button.Key == ConsoleKey.Q) Console.Beep(passedOctave[0], 400);
                if (Button.Key == ConsoleKey.D2) Console.Beep(passedOctave[1], 400);
                if (Button.Key == ConsoleKey.W) Console.Beep(passedOctave[2], 400);
                if (Button.Key == ConsoleKey.D3) Console.Beep(passedOctave[3], 400);
                if (Button.Key == ConsoleKey.E) Console.Beep(passedOctave[4], 400);
                if (Button.Key == ConsoleKey.R) Console.Beep(passedOctave[5], 400);
                if (Button.Key == ConsoleKey.D5) Console.Beep(passedOctave[6], 400);
                if (Button.Key == ConsoleKey.T) Console.Beep(passedOctave[7], 400);
                if (Button.Key == ConsoleKey.D6) Console.Beep(passedOctave[8], 400);
                if (Button.Key == ConsoleKey.Y) Console.Beep(passedOctave[9], 400);
                if (Button.Key == ConsoleKey.D7) Console.Beep(passedOctave[10], 400);
                if (Button.Key == ConsoleKey.U) Console.Beep(passedOctave[11], 400);
                if (Button.Key == ConsoleKey.Enter) Environment.Exit(1);
                Console.Clear();
                Button = Console.ReadKey();
            }
        }

        static int[] smenaOctaves(int octave)
        {
            int[] FirstOctave1 = new int[12] { 16, 17, 18, 19, 20, 21, 23, 24, 25, 27, 29, 30 };
            int[] SecondOctave2 = new int[12] { 32, 34, 36, 38, 41, 43, 46, 49, 51, 55, 58, 61 };
            int[] ThirdOctave3 = new int[12] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
            int[] FourthOctave4 = new int[12] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
            int[] FivethsOctave5 = new int[12] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
            int[] SixthOctave6 = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
            int[] SeventhOctave7 = new int[12] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            int[] EighthOctave8 = new int[12] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            int[] NinethOctave9 = new int[12] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };

            if (octave == 1) return FirstOctave1;
            else if (octave == 2) return SecondOctave2;
            else if (octave == 3) return ThirdOctave3;
            else if (octave == 4) return FourthOctave4;
            else if (octave == 5) return FivethsOctave5;
            else if (octave == 6) return SixthOctave6;
            else if (octave == 7) return SeventhOctave7;
            else if (octave == 8) return EighthOctave8;
            else return NinethOctave9;
        }
    }
}