using System;
using System.Reflection;
namespace Lesson34HomeWork34_Task1
{
    public class Search
    {
        public string ValidateUser(Staff user)
        {
            Type t = typeof(Staff);
            object[] attrs = t.GetCustomAttributes(false);
            MethodInfo[] methods = t.GetMethods();
            string text = "";
            foreach (var method in methods)
            {
                attrs = method.GetCustomAttributes(typeof(AccessLevelAttribute), false);
                foreach (AccessLevelAttribute attribute in attrs)
                {
                    if (user.WorkPositionName == attribute.WorkPosition)
                    {
                        string userName = user.WorkPositionName;
                        try
                        {
                            switch (userName)
                            {
                                case "Director":
                                    text = user.SecutityMethodDirector();
                                    break;
                                case "Manager":
                                    text = user.SecutityMethodMananger();
                                    break;
                                case "Programmer":
                                    text = user.SecutityMethodProgrammer();
                                    break;
                                default:
                                    Console.WriteLine($"Access to the protective section for {user.WorkPositionName} closed!");
                                    break;
                            }
                            return text;
                        }
                        catch (NullReferenceException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Access to the protective section for {user.WorkPositionName} closed!");
                    }
                }
            }
            return text;
        }
    }
}
