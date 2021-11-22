using System;
namespace Lesson15HomeWork15_Task2
{
    public static class Player
    {
        public static void Play(Note[] notes)
        {
            for (int j = 0; j < notes.Length; j++)
            {
                 Console.Beep(notes[j].Frequency, notes[j].Duration);
            }
        }
    }
}
