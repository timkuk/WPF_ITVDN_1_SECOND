using System;
namespace Lesson15HomeWork15_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string melody = "987 876 765 654 543 432 111 8";
            Note[] play = MelodyParser.ParseMelody(melody);
            Player.Play(play);
        }
    }
}
