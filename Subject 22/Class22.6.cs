// Разделить и соединить строки.
using System;

namespace ca2
{
    class SplitAndJoinDemo
    {
        static void Main()
        {
            string str = "Один на суше, другой на море.";
            char[] seps = { ' ', '.', ',' };

            // Разделить строку на части.
            string[] parts = str.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Резульат разделения строки: ");
            for (int i = 0; i < parts.Length; i++)
                Console.WriteLine(parts[i]);

            // А теперь соединить части строки.
            string whole = String.Join(" | ", parts);
            Console.WriteLine("Результат соединения строки: ");
            Console.WriteLine(whole);
        }
    }
}
