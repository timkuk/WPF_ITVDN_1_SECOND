using System;
//Создать класс Book. Создать классы Title, Author и Content,
//каждый из которых должен содержать одно строковое поле и метод void Show().
//Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
//Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
namespace Lesson10HomeWork10_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Title title = new Title();
            string bookTitle = title.title = "Lost Of Us";
            Author author = new Author();
            string bookAuthor =  author.nameAuthor = "Stiven Spilberg";
            Content content = new Content();
            string bookContent =  content.content = "Another way...";
            Book book = new Book(bookTitle, bookAuthor, bookContent);
            book.Show();
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
