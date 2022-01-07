using Lesson33HomeWork33_Task2;
using System;
using System.IO;
using System.Reflection;
//Создайте программу, в которой предоставьте пользователю доступ к сборке из Задания 2
//Реализуйте использование метода конвертации значения температуры из шкалы Цельсия в шкалу Фаренгейта. Выполняя задание используйте только рефлексию
namespace Lesson33HomeWork33_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = null;
            try
            {
                assembly = Assembly.Load("Lesson33HomeWork33_Task2");
                Console.WriteLine("Loaded CarLibrary assembly");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            ListAllTypes(assembly);
            ListAllMembers(assembly);
            UseMethodForReflection(assembly);
            Console.ReadKey();
        }

        private static void ListAllTypes(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));
            Console.WriteLine("\nListAllTypes in: {0} \n", assembly.FullName);
            Type[] types = assembly.GetTypes();
            foreach (Type t in types)
                Console.WriteLine("Type: {0}", t);
        }

        private static void ListAllMembers(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));
            Type type = assembly.GetType("Lesson33HomeWork33_Task2.Kelvins");
            Console.WriteLine("\nListAllMembers for: {0} \n", type);
            MemberInfo[] members = type.GetMembers();
            foreach (MemberInfo element in members)
                Console.WriteLine("{0,-15}:  {1}", element.MemberType, element);
        }
        public static void UseMethodForReflection(Assembly assembly)
        {
            Type type = assembly.GetType("Lesson33HomeWork33_Task2.Forengeits");
            //Используя рефлексию заполняем конструтор типа Forengeits и вызываем метод который использует в качестве переменной переменную из нашего конструктора
            var instance = (Forengeits)Activator.CreateInstance(typeof(Forengeits), 40);
            MethodInfo method = type.GetMethod("ConvertTemperature");
            method.Invoke(instance, null);
        }
    }
}

