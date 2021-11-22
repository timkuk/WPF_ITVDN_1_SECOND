using System;
using System.Text;
//Расширьте русско-английский словарь еще и украинским словарем
//Реализуйте возможность поиска не только по ключевым русским словам и словам на остальных языках.
namespace Lesson14HomeWork14_Task1
{
    public class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];
        private string[] transcription = new string[5];
        /// <summary>
        /// Realization user constructor
        /// </summary>
        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book";   transcription[0]   = "падручник";
            key[1] = "ручка"; value[1] = "pen";    transcription[1]   = "пяро";
            key[2] = "солнце"; value[2] = "sun";   transcription[2]   = "сонца";
            key[3] = "яблоко"; value[3] = "apple"; transcription[3]   = "яблоко";
            key[4] = "стол"; value[4] = "table";    transcription[4]   = "стол";
        }
        /// <summary>
        /// Reealization Indexator
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index)
                        return key[i] + " - " + value[i] + " - " + transcription[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }
        /// <summary>
        /// Reealization Indexator
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index] + " - " + transcription[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
