// Отформатировать дату и время, используя специальные форматы.
using System;

namespace ca2
{
    class CustomTimeAndDateFormatsDemo
    {
        static void Main()
        {
            DateTime dt = DateTime.Now;

            Console.WriteLine("Время: {0:hh:mm tt}", dt);
            Console.WriteLine("Время в 24-часовом формате: {0:HH:mm}", dt);
            Console.WriteLine("Дата: {0:ddd MMM dd, yyyy}", dt);

            Console.WriteLine("Эра: {0:gg}", dt);

            Console.WriteLine("Время в секундах: {0:HH:mm:ss tt}", dt);

            Console.WriteLine("День месяца в формате m: {0:m}", dt);
            Console.WriteLine("Минуты в формате m: {0:%m}", dt);
        }
    }
}
