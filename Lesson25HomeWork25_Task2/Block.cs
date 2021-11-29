using System;
//Создайте класс Block с 4-мя полями сторон, переопределите в нем методы: 
//Equals – способный сравнивать блоки между собой,
//ToString – возвращающий информацию о полях блока.
namespace Lesson25HomeWork25_Task2
{
    public class Block
    {
        public int firstSide { get; set; }
        public int secondSide { get; set; }
        public int tirdSide { get; set; }
        public int fourSide { get; set; }

        public Block(int firstSide, int secondSide, int tirdSide, int fourSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.tirdSide = tirdSide;
            this.fourSide = fourSide;
        }
        public override string ToString()
        {
            return $"Information about fields of blok firstSide ->{firstSide} secondSide-> {secondSide} tirdSide-> {tirdSide} fourSide ->{fourSide}";
        }
        public override bool Equals(object item)
        {
            if (this.GetType() != item.GetType())
            {
                return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
