// Создать и вывести символьную строку.
using System;

namespace ca2
{
    class StringDemo
    {
        static void Main()
        {
            char[] charray = { 'Э', 'т', 'о', ' ', 'c', 'т', 'р', 'о', 'к', 'а' };

            string str1 = new string(charray);
            string str2 = "Еще одна строка";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}
