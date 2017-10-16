// Ввод с консоли с помощью метода ReadLine().
using System;

namespace ca2
{
    class ReadString
    {
        static void Main()
        {
            string str;

            Console.WriteLine("Введите несколько символов.");
            str = Console.In.ReadLine(); // вызвать метод ReadLine() класса TextReader
            Console.WriteLine("Вы ввели: " + str);
        }
    }
}
