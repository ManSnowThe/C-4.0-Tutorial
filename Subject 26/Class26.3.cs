// Пример применения свойств из класса Uri.
using System;
using System.Net;

namespace ca2
{
    class UriDemo
    {
        static void Main()
        {
            Uri sample = new Uri("http://vk.com/somefile.txt?SomeQuery");
            Console.WriteLine("Хост: " + sample.Host);
            Console.WriteLine("Порт: " + sample.Port);
            Console.WriteLine("Протокол: " + sample.Scheme);
            Console.WriteLine("Локальный путь: " + sample.LocalPath);
            Console.WriteLine("Запрос: " + sample.Query);
            Console.WriteLine("Путь и запрос: " + sample.PathAndQuery);
        }
    }
}
