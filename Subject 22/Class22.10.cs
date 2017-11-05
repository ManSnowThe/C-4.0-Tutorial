// Использовать метод Substring().
using System;

namespace ca2
{
    class SubstringDemo
    {
        static void Main()
        {
            string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Console.WriteLine("Строка str: " + str);

            Console.Write("Подстрока str.Substring(15): ");
            string substr = str.Substring(15);
            Console.WriteLine(substr);

            Console.Write("Подстрока str.Substring(0, 15): ");
            substr = str.Substring(0, 15);
            Console.WriteLine(substr);
        }
    }
}
