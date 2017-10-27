﻿// Использовать два вложенных оператора from для составления списка
// всех возможных сочетаний букв А, В и С с буквами X, Y и Z.
using System;
using System.Linq;

namespace ca2
{
    // Этот класс содержит результат запроса.
    class ChrPair
    {
        public char First;
        public char Second;

        public ChrPair(char c, char c2)
        {
            First = c;
            Second = c2;
        }
    }
    class MultipleFroms
    {
        static void Main()
        {
            char[] chrs = { 'A', 'B', 'C' };
            char[] chrs2 = { 'X', 'Y', 'Z' };

            // В первом операторе from организуется циклическое обращение
            // к массиву символов chrs, а во втором операторе from —
            // циклическое обращение к массиву символов chrs2.
            var pairs = from ch1 in chrs
                        from ch2 in chrs2
                        select new ChrPair(ch1, ch2);

            Console.WriteLine("Все сочетания букв ABC и XYZ: ");
            foreach (var p in pairs)
                Console.WriteLine("{0} {1}", p.First, p.Second);
        }
    }
}
