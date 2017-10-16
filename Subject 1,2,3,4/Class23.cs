// Продемонстрировать применение поразрядного оператора исключающее ИЛИ.

using System;

namespace ca2
{
    class EnCode
    {
        static void Main()
        {
            char ch1 = 'H';
            char ch2 = 'i';
            char ch3 = '!';
            int key = 90;

            Console.WriteLine("Исходное сообщение: " + ch1 + ch2 + ch3);

            //Зашифровать сообщение
            ch1 = (char)(ch1 ^ key);
            ch2 = (char)(ch2 ^ key);
            ch3 = (char)(ch3 ^ key);

            Console.WriteLine("Зашифрованное сообщение: " + ch1 + ch2 + ch3);

            //Расшифровать сообщение
            ch1 = (char)(ch1 ^ key);
            ch2 = (char)(ch2 ^ key);
            ch3 = (char)(ch3 ^ key);

            Console.WriteLine("Расшифрованное сообщение: " + ch1 + ch2 + ch3);
        }
    }
}