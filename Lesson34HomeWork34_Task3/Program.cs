using Lesson33HomeWork33_Task2;
using System;
using System.IO;
using System.Reflection;
//1.Добавьте возможность выбирать, какие именно члены типа должны быть показаны пользователю
//При этом должна быть возможность выбирать сразу несколько членов типа, например, методы и свойства
//2.Добавьте возможность вывода информации об атрибутах для типов и всех членов типа,которые могут быть декорированы атрибутами
namespace Lesson34HomeWork34_Task3
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false)]
    public class Program : System.Attribute
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите какие члены типа вы хотите вывести в консоль");
            Console.WriteLine("1 - Методы и Свойства 2 - Получить информацию о всех типах");
            int input = int.Parse(Console.ReadLine());
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
            if (input == 1)
            {
                ListMethodsAndProperties(assembly);
            }
            else
            {
                ListAllTypes(assembly);
            }
            ListAllMembersWithAttributes(assembly);
            //ListAllMembers(assembly);
            //UseMethodForReflection(assembly);
            Console.ReadKey();
        }
        private static void ListMethodsAndProperties(Assembly assembly)
        {
            Type type = typeof(ConvertationTemperature);
            MethodInfo[] methods = type.GetMethods();
            PropertyInfo[] properties = type.GetProperties();
            foreach(var method in methods)
            {
                foreach (var property in properties)
                {
                    Console.WriteLine($"Информация о методе {method.Name} + информация о свойстве {property.Name}");
                }
            }
        }
        private static void ListAllTypes(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));
            Console.WriteLine("\nListAllTypes in: {0} \n", assembly.FullName);
            Type[] types = assembly.GetTypes();
            foreach (Type t in types)
                Console.WriteLine("Type: {0}", t);
        }

        private static void ListAllMembersWithAttributes(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));
            Type type = typeof(Forengeits);
            object[] atributes = type.GetCustomAttributes(false);
            foreach (TemperatureAtribute atribut in atributes)
                Console.WriteLine($"Information about atributes {atribut.Temperaturka}");
            //Атрибуты могут использоватся со всеми членами,поэтому на экран консоли можно вывести инфу о всех членах класса
            Console.WriteLine(new string('_', 80));
            type = assembly.GetType("Lesson33HomeWork33_Task2.Forengeits");
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

