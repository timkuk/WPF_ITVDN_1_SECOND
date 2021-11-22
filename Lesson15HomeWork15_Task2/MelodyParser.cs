using System;
using System.Linq;
//Создать класс Note, представляющий музыкальную ноту. Класс Note должен содержать следующие 
//данные: частота, продолжительность в миллисекундах и значение типа bool, указывающее, является ли 
//нота паузой. Создать 7 фабричных методов для создания нот (до, ре, ми, фа, соль, ля, си), фабричные
//методы в качестве параметров должны принимать номер октавы для соответствующей ноты и значение 
//продолжительности в миллисекундах.
//Создать статический класс MelodyParser с методом для преобразовния строки из цифр и пробелов в 
//массив нот:
//Note[] ParseMelody(string melody). Цифры от 0 до 9 соответствуют 10 последовательным нотам на Ваше усмотрение, пробел – паузе.
//Продолжительность звучания нот одинаковая и устанавливается на Ваше усмотрение.
//Создать статический класс Player с методом для последовательного воспроизведения массива нот с 
//помощью метода Console.Beep: 
//void Play(Note[] notes).
//Пример использования описанных классов:
//string melody = "987 876 765 654 543 432 111 8";
//Note[] notes = MelodyParser.ParseMelody(melody);
//Player.Play(notes);
namespace Lesson15HomeWork15_Task2
{
    public static class  MelodyParser
    {
        public static Note CreateNoteDo(int actNumber, int duration)
        {
            int frequancy = actNumber * duration;
            return new Note(frequancy, duration);
        }
        public static Note CreateNoteRe(int actNumber, int duration)
        {
            int frequancy = actNumber * duration;
            return new Note(frequancy, duration);
        }
        public static Note CreateNoteMi(int actNumber, int duration)
        {
            int frequancy = actNumber * duration;
            return new Note(frequancy, duration);
        }
        public static Note CreateNoteFa(int actNumber, int duration)
        {
            int frequancy = actNumber * duration;
            return new Note(frequancy, duration);
        }
        public static Note CreateNoteSol(int actNumber, int duration)
        {
            int frequancy = actNumber * duration;
            return new Note(frequancy, duration);
        }
        public static Note CreateNoteLa(int actNumber, int duration)
        {
            int frequancy = actNumber * duration;
            return new Note(frequancy, duration);
        }
        public static Note CreateNoteSi(int actNumber, int duration)
        {
            int frequancy = actNumber * duration;
            return new Note(frequancy, duration);
        }
        public static Note CreateNoteDoRe(int actNumber, int duration)
        {
            int frequancy = actNumber * duration;
            return new Note(frequancy, duration);
        }
        public static Note CreateNoteSiDo(int actNumber, int duration)
        {
            int frequancy = actNumber * duration;
            return new Note(frequancy, duration);
        }
        public static Note CreatePause(int actNumber, int duration)
        {
            int frequancy = actNumber * duration;
            return new Note(frequancy, duration,true);
        }
        /// <summary>
        /// Realization method ParseMelody
        /// </summary>
        /// <param name="melody"></param>
        /// <returns></returns>
        public static Note[] ParseMelody(string melody)
        {
            char[] note = melody.ToCharArray();
            int[] intMelodySplit = new int[note.Length];
            Note[] notes = new Note[intMelodySplit.Length];
            for (int j = 0; j < note.Length; j++)
            {
                if (int.TryParse(note[j].ToString(), out int w))
                {
                    intMelodySplit[j] = w;
                }
            }
            for(int k = 0; k < intMelodySplit.Length; k++)
            {
                notes[k] = GetNote(intMelodySplit[k]);
            }
            return notes;
        }
        /// <summary>
        /// Realization method GetNote
        /// </summary>
        /// <param int="notes"></param>
        /// <returns></returns>
        public static Note GetNote(int notes)
        {
            Note result = null;
                switch (notes)
                {
                    case 0:
                        result = CreatePause(1, 2000);
                        break;
                    case 1:
                        result = CreateNoteDo(30, 23);
                        break;
                    case 2:
                        result = CreateNoteRe(40, 26);
                        break;
                    case 3:
                        result = CreateNoteMi(50, 28);
                        break;
                    case 4:
                        result = CreateNoteFa(60, 35);
                        break;
                    case 5:
                        result = CreateNoteSol(70, 40);
                        break;
                    case 6:
                        result = CreateNoteLa(80, 45);
                        break;
                    case 7:
                        result = CreateNoteSi(90, 50);
                        break;
                    case 8:
                        result = CreateNoteDoRe(100, 150);
                        break;
                    case 9:
                        result = CreateNoteSiDo(100, 250);
                        break;
                    default:
                        result = CreatePause(1, 2000);
                        break;
                }
            return result;
        }
    }
}
