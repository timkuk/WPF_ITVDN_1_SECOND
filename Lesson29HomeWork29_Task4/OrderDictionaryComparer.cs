using System;
using System.Collections;

namespace Lesson29HomeWork29_Task4
{
    public class OrderedDictionaryComparer : IEqualityComparer
    {
        public bool Equals(DictionaryEntry x, DictionaryEntry y)
        {
            if (x.Key != null && y.Key != null)
            {
                if (x.Key == y.Key)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Equals(object x, object y)
        {
            if (x != null && y != null)
            {
                if (x == y)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(DictionaryEntry obj)
        {
            return obj.Key.GetHashCode();
        }

        public int GetHashCode(object obj)
        {
            return obj.GetHashCode();
        }
    }
}
