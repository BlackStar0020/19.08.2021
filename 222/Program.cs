using System;

namespace _222
{
 class Book
    {
        public Title title { get; set; }
        public Author author { get; set; }
        public Content content { get; set; }

        public Book(string titleId, string authorId, string contentId)
        {
            title = new Title();
            author = new Author();
            content = new Content();
            title.title = titleId;
            author.author = authorId;
            content.content = contentId;

        }
        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
            
        }
    }
    class Title
    {
        public string title = "";
        public void Show()
        {
            Console.Write("Nazvanie: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(title);
            Console.ResetColor();
        }
    }
    class Author
    {
        public string author = "";
        public void Show()
        {
            Console.Write("Avtor: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(author);
            Console.ResetColor();
        }
    }
    class Content
    {
        public string content = "";
        public void Show()
        {
            Console.Write("content: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(content);
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Вдали от безумной толпы", "Томас Харди", "Великая и вечная драма в отношений мужчины и женщины\n");
            book.Show();

            Book book1 = new Book("Психология лжи. Обмани меня если сможешь", "Пол Экман", "Научитесь замечать то, чего не видят другие.\n");
            book1.Show();

            Book book2 = new Book("Волшебная на всю голову", "Карина Микиртумова", "Если в жизни наступила чёрная полоса - нарисуй радугу и верь в себя.\n");
            book2.Show();

        }
    }
}
