using System;

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
