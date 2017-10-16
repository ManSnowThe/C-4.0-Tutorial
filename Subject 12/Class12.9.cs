// Продемонстрировать применение структуры.
using System;

namespace ca2
{
    // Определить структуру.
    struct Book
    {
        public string Author;
        public string Title;
        public int Copyright;

        public Book(string a, string t, int c)
        {
            Author = a;
            Title = t;
            Copyright = c;
        }
    }

    // Продемонстрировать применение структуры Book.    class StructDemo
    {
        static void Main()
        {
            Book book1 = new Book("Герберт Шилдт", "Полный справочник пo C# 4.0", 2010); // вызов явно заданного конструктора
            Book book2 = new Book();  // вызов конструктора по умолчанию
            Book book3; // конструктор не вызывается
            Console.WriteLine(book1.Author + ", " + book1.Title + ", (c) " + book1.Copyright);

            Console.WriteLine();

            if (book2.Title == null)
                Console.WriteLine("Член book2.Title пуст.");

            // А теперь ввести информацию в структуру book2.
            book2.Title = "О дивный новый мир";
            book2.Author = "Олдос Хаксли";
            book2.Copyright = 1932;

            Console.Write("Структура book2 теперь содержит:\n");
            Console.WriteLine(book2.Author + ", " + book2.Title + ", (c) " + book2.Copyright);

            Console.WriteLine();

            // Console.WriteLine(bookЗ.Title); // неверно, этот член структуры нужно сначала инициализировать

            book3.Title = "Красный шторм";
            Console.WriteLine(book3.Title); // теперь верно
        }
    }
}
