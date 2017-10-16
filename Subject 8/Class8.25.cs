// Вывести все аргументы командной строки.
using System;

namespace ca2
{
    class CLDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Консольная строка содержит " + args.Length + " аргумента.");

            Console.WriteLine("Вот они: ");
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine(args[i]);
        }
    }
}
