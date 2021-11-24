using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson24HomeWork24_Task3
{
    class PriceCpmpare : IComparer<Price>
    {
        public int Compare(Price a, Price b)
        {
            return a.NameShop.CompareTo(b.NameShop);
        }
    }
}

