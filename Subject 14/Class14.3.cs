// Считать символы, введенные с консоли, используя метод ReadKey().
using System;

namespace ca2
{
    class ReadKeys
    {
        static void Main()
        {
            ConsoleKeyInfo keypress;

            Console.WriteLine("Введите несколько символов, а по окончании - <Q>.");
            do
            {
                keypress = Console.ReadKey(); // считать данные о нажатых клавишах
                Console.WriteLine(" Вы нажали клавишу: " + keypress.KeyChar);

                // Проверить нажатие модифицирующих клавиш.
                if ((ConsoleModifiers.Alt & keypress.Modifiers) != 0)
                    Console.WriteLine("Нажата клавиша <Alt>.");

                if ((ConsoleModifiers.Control & keypress.Modifiers) != 0)
                    Console.WriteLine("Нажата клавиша <Control>.");

                if ((ConsoleModifiers.Shift & keypress.Modifiers) != 0)
                    Console.WriteLine("Нажата клавиша <Shift>.");
            }
            while (keypress.KeyChar != 'Q');
        }
    }
}
