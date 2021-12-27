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
        const string patternForNumber = @"(?:\+|\d)[\d\-\(\) ]{9,}\d";
        const string patternForEmailAdress = @"[0-9A-Za-z_.-]+@[0-9a-zA-Z-]+\.[a-zA-Z]{2,4}";
        const string patternForAllLinksOnTheSite = @"(http|ftp|https):\/\/([\w_-]+(?:(?:\.[\w_-]+)+))([\w.,@?^=%&:\/~+#-]*[\w@?^=%&\/~+#-])";
        public static async Task Main()
        {
            var numberRegex = new Regex(patternForNumber);
            var emailRegex = new Regex(patternForEmailAdress);
            var linksRegex = new Regex(patternForAllLinksOnTheSite);
            try
            {
                StreamReader reader = File.OpenText(@"E:\ITVDN\03_C# Essential\WPF_ITVDN_1-master\Lesson31HomeWork31_Task2\Код сайта для парсинга.txt");
                string testParsing = reader.ReadToEnd();
                var coll = numberRegex.Matches(testParsing);
                var emai = emailRegex.Matches(testParsing);
                var links = linksRegex.Matches(testParsing);
                var file = new FileInfo(@"E:\ITVDN\03_C# Essential\WPF_ITVDN_1-master\Lesson31HomeWork31_Task2\Результат парсинга.txt");
                StreamWriter writer = file.CreateText();
                writer.Write("Номера телефонов с сайта:");
                for (int i = 0; i < coll.Count; i++)
                {
                    writer.Write($"\n {coll[i].Value}");
                    Console.WriteLine(coll[i].Value);
                }
                writer.Write("\n Почта с сайта:");
                for (int i = 0; i < emai.Count; i++)
                {
                    writer.Write($"\n {emai[i].Value}");
                    Console.WriteLine(emai[i].Value);
                }
                writer.Write("\n Ссылки с сайта:");
                for (int i = 0; i < links.Count; i++)
                {
                    writer.Write($"\n {links[i].Value}");
                    Console.WriteLine(links[i].Value);
                }
                writer.Close();
                Console.ReadKey();
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
