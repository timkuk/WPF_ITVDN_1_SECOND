using System;
//частота, продолжительность в миллисекундах и значение типа bool, указывающее, является ли 
//нота паузой. Создать 7 фабричных методов для создания нот (до, ре, ми, фа, соль, ля, си), фабричные
//методы в качестве параметров должны принимать номер октавы для соответствующей ноты и значение продолжительности в миллисекундах.
//Создать статический класс MelodyParser с методом для преобразовния строки из цифр и пробелов в массив нот:
//Note[] ParseMelody(string melody). Цифры от 0 до 9 соответствуют 10 последовательным нотам на Ваше усмотрение, пробел – паузе.
//Продолжительность звучания нот одинаковая и устанавливается на Ваше усмотрение.
//Создать статический класс Player с методом для последовательного воспроизведения массива нот с помощью метода Console.Beep: 
//void Play(Note[] notes).
namespace Lesson15HomeWork15_Task2
{
    public class Note
    {
        /// <summary>
        /// Частота
        /// </summary>
        private  int frequency;
        /// <summary>
        /// Длительность
        /// </summary>
        private  int duration;
        /// <summary>
        /// Является ли паузой
        /// </summary>
        private bool itIsPause;
        /// <summary>
        /// Номер актавы
        /// </summary>
        private  int actNumber;
        /// <summary>
        /// Prpperty Frequency
        /// </summary>
        public int Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                frequency = value;
            }
        }
        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }
        /// <summary>
        /// Prpperty ItIsPause
        /// </summary>
        public bool ItIsPause
        {
            get
            {
                return itIsPause;
            }
            set
            {
                itIsPause = value;
            }
        }
        /// <summary>
        /// Prpperty ActNumber
        /// </summary>
        public int ActNumber
        {
            get
            {
                return actNumber;
            }
            set
            {
                actNumber = value;
            }
        }
        /// <summary>
        /// Create Constrctor
        /// </summary>
        /// <param name="frequency"></param>
        /// <param name="duration"></param>
        public Note(int frequency, int duration,bool itIsPause =false)
        {
            this.frequency = frequency;
            this.duration = duration;
            this.itIsPause = itIsPause;
        }     
    }
}
