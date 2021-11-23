using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson24HomeWork24_Task3
{
    class Program
    {
        //static void Main()
        //{
        //    //Console.SetBufferSize(130, 50);
        //    //Console.SetWindowSize(130, 50);
        //    //char[] a = new char[4];
        //    //a[0] = 'a';
        //    //string str = Convert.ToString(a[0]);
        //    //int tabs = Console.WindowWidth - (Console.WindowWidth - 1); //длина отступа
        //    //str = str.PadLeft(str.Length + tabs, '*'); //правое выравнивание
        //    //Console.WriteLine(str);
        //}
        static void RWDeviceState(int ind)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Поток:" + ind + " Значение:" + i);
            }
        }


        static void Main(string[] args)
        {
            List<Thread> ThrArr = new List<Thread>();
            for (int ind = 0; ind < 10; ind++)
            {
                int temp = ind;
                Thread devthread = new Thread(() => RWDeviceState(temp));
                devthread.Name = "thr" + ind.ToString();
                ThrArr.Add(devthread);
                devthread.Start();
                
            }
            Console.ReadKey();
        }
    }
}
 