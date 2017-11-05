﻿// Отформатировать дату и время, используя стандартные форматы.
using System;

namespace ca2
{
    class TimeAndDateFormatDemo
    {
        static void Main()
        {
            DateTime dt = DateTime.Now; // получить текущее время

            Console.WriteLine("Формат d: {0:d}", dt);
            Console.WriteLine("Формат D: {0:D}", dt);

            Console.WriteLine("Формат t: {0:t}", dt);
            Console.WriteLine("Формат T: {0:T}", dt);

            Console.WriteLine("Формат f: {0:f}", dt);
            Console.WriteLine("Формат F: {0:F}", dt);

            Console.WriteLine("Формат g: {0:g}", dt);
            Console.WriteLine("Формат G: {0:G}", dt);

            Console.WriteLine("Формат m: {0:m}", dt);
            Console.WriteLine("Формат M: {0:M}", dt);

            Console.WriteLine("Формат о: {0:o}", dt);
            Console.WriteLine("Формат O: {0:O}", dt);

            Console.WriteLine("Формат r: {0:r}", dt);
            Console.WriteLine("Формат R: {0:R}", dt);

            Console.WriteLine("Формат s: {0:s}", dt);

            Console.WriteLine("Формат u: {0:u}", dt);
            Console.WriteLine("Формат U: {0:U}", dt);

            Console.WriteLine("Формат y: {0:y}", dt);
            Console.WriteLine("Формат Y: {0:Y}", dt);
        }
    }
}
