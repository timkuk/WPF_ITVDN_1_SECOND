using System;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//Напишите программу, которая бы позволила вам по указанному адресу web-страницы 
//выбирать все ссылки на другие страницы, номера телефонов, почтовые адреса и сохраняла полученный результат в файл
namespace Lesson31HomeWork31_Task2
{
    public class Program
    {
        static readonly HttpClient client = new HttpClient();
        const string patternForNumber = @"^((8|\+374|\+994|\+995|\+375|\+7|\+380|\+38|\+996|\+998|\+993)[\- ]?)?\(?\d{3,5}\)?[\- ]?\d{1}[\- ]?\d{1}[\- ]?\d{1}[\- ]?\d{1}[\- ]?\d{1}(([\- ]?\d{1})?[\- ]?\d{1})?$";
        const string patternForEmailAdress = @"[0-9A-Za-z_.-]+@[0-9a-zA-Z-]+\.[a-zA-Z]{2,4}";
        const string patternForAllLinksOnTheSite = @"\b(\w){1}\b";
        public static async Task Main()
        {
            var numberRegex = new Regex(patternForNumber);
            var emailRegex = new Regex(patternForEmailAdress);
            var linksRegex = new Regex(patternForAllLinksOnTheSite);
            try
            {
                StreamReader reader = File.OpenText(@"E:\ITVDN\03_C# Essential\WPF_ITVDN_1-master\Lesson31HomeWork31_Task2\Код сайта для парсинга.txt");
                string testParsing = reader.ReadToEnd();
                var coll = linksRegex.Matches(testParsing);
                var file = new FileInfo(@"E:\ITVDN\03_C# Essential\WPF_ITVDN_1-master\Lesson31HomeWork31_Task2\Результат парсинга.txt");
                StreamWriter writer = file.CreateText();
                writer.Write(coll);
                writer.Close();
                var splitText = testParsing.Split(' ');
                foreach(var splitword in splitText)
                {
                    if ((numberRegex.IsMatch(splitword)) || (emailRegex.IsMatch(splitword)) || linksRegex.IsMatch(splitword))
                    {
                        //var file = new FileInfo(@"E:\ITVDN\03_C# Essential\WPF_ITVDN_1-master\Lesson31HomeWork31_Task2\Результат парсинга.txt");
                        //StreamWriter writer = file.CreateText();
                        //writer.Write(splitword);
                        //writer.Close();
                    }
                }
                HttpResponseMessage response = await client.GetAsync("https://mebel.by/allproducts.php?firms=8/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
