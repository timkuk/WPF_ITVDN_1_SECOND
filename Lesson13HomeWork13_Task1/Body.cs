using System;

namespace Lesson13HomeWork13_Task1
{
        public class Body : Document
        {
            string content;

            public string Content
            {
                private get
                {
                    if (content != null)
                        return content;
                    else
                        return "Тело документа отсутствует.";
                }
                set
                {
                    content = value;
                }
            }
            public void Oleg()
        {
            Console.WriteLine("Stupid");

        }
            public override void Show()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Content);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }

