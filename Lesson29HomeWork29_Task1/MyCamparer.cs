using System;
using System.Collections;

namespace Lesson29HomeWork29_Task1
{
    public class MyCamparer :IComparer
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
        public int Compare(object x,object y)
        {
            int resilt = comparer.Compare(y, x);
            return resilt;
        }
    }
}
