using System;

namespace Lesson17HomeWork17_Task3
{
    /// <summary>
    /// Realization class Accountant
    /// </summary>
    public class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker > 100)
            {
                Console.WriteLine("Post take additional money for salary!");
                return true;
            }
            else if((int)worker <= 100)
            {
                Console.WriteLine("Post NO take  money for salary!");
                return false;
            }
            return true;
        }
    }
}
