using System;

namespace Lesson34HomeWork34_Task2
{
    [Obsolete("This is an old class. Use new class instead!", false)]
    //[Obsolete("This is an old class. Use new class instead!",true)]
    public class MyObsolete
    {
        public void Relese()
        {
            Console.WriteLine("Relese working!");
        }
    }
}
