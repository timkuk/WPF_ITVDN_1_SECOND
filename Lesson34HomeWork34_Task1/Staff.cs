using System;
namespace Lesson34HomeWork34_Task1
{
    public class Staff
    {
        public string WorkPositionName { get; set; }
        public string NameWorker { get; set; }
        public Staff(string WorkPositionName, string NameWorker)
        {
            this.WorkPositionName = WorkPositionName;
            this.NameWorker = NameWorker;
        }
        [AccessLevel("Director")]
        public string SecutityMethodDirector()
        {
            return "I can use this method becouse i am director";
        }
        [AccessLevel("Manager")]
        public string SecutityMethodMananger()
        {
            return "I can use this method becouse i am  mananger";
        }
        [AccessLevel("Programmer")]
        public string SecutityMethodProgrammer()
        {
            return "I can use this method becouse i am programmist";
        }
    }
}
