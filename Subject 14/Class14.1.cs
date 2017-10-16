// Считать символ, введенный с клавиатуры.
using System;

namespace ca2
{
    class KbIn
    {
        static void Main()
        {
            char ch;

            Console.WriteLine("Нажмите клавишу, а затем — <ENTER>: ");

            ch = (char)Console.Read(); // получить значение типа char
            Console.WriteLine("Вы нажали клавишу: " + ch);  
        }
    }
}
