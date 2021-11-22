using System;

namespace Lesson4HomeWork4_Task0
{
    class Program
    {
        /// <summary>
        /// I know what i can used construction switch case)
        /// </summary>
        /// <param name="args"></param>
       
    static void Main(string[] args)
        {
            Console.WriteLine("Перевод слов погоды с русского на английский  \n Введите погоду");
            string word = Console.ReadLine();
            switch (word)
            {
                case "солнечно":
                    Console.WriteLine("sunny");
                    break;
                case "пасмурно":
                    Console.WriteLine("cloudy");
                    break;
                case "ветренно":
                    Console.WriteLine("windy");
                    break;
                case "жарко":
                    Console.WriteLine("hot");
                    break;
                case "облачно с прояснениями":
                    Console.WriteLine("cloudy with some clarifications");
                    break;
                case "хреново":
                    Console.WriteLine("it sucks");
                    break;
                case "все достало":
                    Console.WriteLine("I'm sick of everything");
                    break;
                case "хочу спать":
                    Console.WriteLine("want to sleep");
                    break;
                case "хочу есть":
                    Console.WriteLine("want eat");
                    break;
                case "хочу":
                    Console.WriteLine("want");
                    break;
                default:
                    Console.WriteLine("Такого слова нет");
                    break;
            }

            //if (word == "солнечно")
            //{
            //    Console.WriteLine("sunny");
            //}
            //    else if (word == "пасмурно")
            //    {
            //    Console.WriteLine("cloudy");
            //    }
            //        else if (word == "ветренно")
            //        {
            //            Console.WriteLine("windy");
            //        }
            //            else if (word == "жарко")
            //            {
            //                Console.WriteLine("hot");
            //            }
            //                else if (word == "облачно с прояснениями")
            //                {
            //                    Console.WriteLine("cloudy with some clarifications");
            //                }
            //                    else if (word == "хреново")
            //                    {
            //                        Console.WriteLine("it sucks");
            //                    }
            //                        else if (word == "все достало")
            //                        {
            //                            Console.WriteLine("I'm sick of everything");
            //                        }
            //                            else if (word == "хочу спать")
            //                            {
            //                                Console.WriteLine("want to sleep");
            //                            }
            //                                else if (word == "хочу есть")
            //                                {
            //                                    Console.WriteLine("want to eat");
            //                                }
            //                                    else if (word == "хочу")
            //                                    {
            //                                        Console.WriteLine("want");
            //                                    }   
        }
    }
}
