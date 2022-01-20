using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson37HomeWork37_Task2
{
    public abstract class Cripta
    {
        public void AllSettings()
        {
            Mining();
            ChangeToDollors();
            BuyDrugsFromDarkNet();
        }
        public abstract void Mining();
        public abstract void ChangeToDollors();
        public abstract void BuyDrugsFromDarkNet();
    }
}
