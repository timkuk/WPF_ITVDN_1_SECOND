using System;
namespace Lesson32HomeWork32_Task5
{
    public class Information
    {
        private string ID;
        private string Login;
        private string Password;
        public string IDField
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }
        public string LoginField
        {
            get
            {
                return Login;
            }
            set
            {
                Login = value;
            }
        }
        public string PasswordField
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
    }
}