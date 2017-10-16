// Применить методы Exists() и GetLastAccessTime().
using System;
using System.IO;

namespace ca2
{
    class ExistsDemo
    {
        static void Main()
        {
            if (File.Exists("test.txt"))
                Console.WriteLine("Файл существует. Последний раз он был доступен " + File.GetLastWriteTime("test.txt"));
            else
                Console.WriteLine("Файл не существует");
        }
    }
}
