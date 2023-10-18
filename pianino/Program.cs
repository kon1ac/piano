using System; 
using System.Linq; 
using System.Media; 
using System.Runtime.InteropServices; 
using System.Threading; 
  
public class Piano 
{ 
    private int[] firstOctave = new int[] { 262, 294, 330, 349, 392, 440, 494 }; 
    private int[] secondOctave = new int[] { 523, 587, 659, 698, 784, 880, 988 }; 
    private int[] currentOctave; 
  
    public Piano() 
    { 
        currentOctave = firstOctave;  
    } 
  
    private void PlaySound(int frequency, int duration) 
    { 
        Console.Beep(frequency, duration); 
    } 
  
    private int[] ChangeOctave(int octave) 
    { 
        switch (octave) 
        { 
            case 2: 
                return secondOctave; 
            default: 
                return firstOctave; 
        } 
    } 
  
    public void Start() 
    { 
        int octave = 1; 
        Console.WriteLine("Для смены октавы используйте клавиши F1, F2, F3 и т.п."); 
  
        while (true) 
        { 
            if (Console.KeyAvailable) 
            { 
                ConsoleKeyInfo keyInfo = Console.ReadKey(true); 
  
                if (keyInfo.Key == ConsoleKey.F1) 
                { 
                    octave = 1; 
                    currentOctave = ChangeOctave(octave); 
                } 
                else if (keyInfo.Key == ConsoleKey.F2) 
                { 
                    octave = 2; 
                    currentOctave = ChangeOctave(octave); 
                } 
                else if (keyInfo.Key == ConsoleKey.Escape) 
                { 
                    break; 
                } 
                else 
                { 
                    int keyNoteIndex = Array.IndexOf(currentOctave, (int)keyInfo.KeyChar); 
  
                    if (keyNoteIndex != -1) 
                    { 
                        PlaySound(currentOctave[keyNoteIndex], 200); 
                    } 
                } 
            } 
  
            Thread.Sleep(10); 
        } 
    } 
} 
  
public class Program 
{ 
    static void Main(string[] args) 
    { 
        Piano piano = new Piano(); 
        piano.Start(); 
    } 
}
