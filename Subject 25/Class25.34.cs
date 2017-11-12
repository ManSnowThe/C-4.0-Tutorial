// Инициализаторы коллекций
using System;
using System.Collections.Generic;

namespace ca2
{
    class InGen
    {
        static void Main()
        {
            List<char> lst = new List<char>() { 'С', 'А', 'Е', 'В', 'D', 'F' };

            foreach (char ch in lst)
                Console.Write(ch + " ");

            Console.WriteLine();

            SortedList<int, string> sl = new SortedList<int, string>() { { 1, "один" }, { 2, "два" }, { 3, "три" } };

            ICollection<int> c = sl.Keys;

            foreach (int k in c)
                Console.Write("{0} - {1}, ", k, sl[k]);
        }
    }
}
