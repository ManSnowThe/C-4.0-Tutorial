// Продемонстрировать применение метода Contains().
using System;

namespace ca2
{
    class ContainsDemo
    {
        static void Main()
        {
            string str = "C# сочетает эффективность с производительностью.";

            if (str.Contains("эффективность"))
                Console.WriteLine("Обнаружена подстрока \"эффективность\".");

            if (str.Contains("эффе"))
                Console.WriteLine("Обнаружена подстрока \"эффе\".");

            if(!str.Contains("эффективный"))
                Console.WriteLine("Подстрока \"эффективный\" не обнаружена.");
        }
    }
}
