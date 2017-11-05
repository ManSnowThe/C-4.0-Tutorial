// Компьютерный вариант пары игральных костей.
using System;

namespace ca2
{
    class RandDice
    {
        static void Main()
        {
            Random ran = new Random();

            Console.Write(ran.Next(1, 7) + " ");
            Console.WriteLine(ran.Next(1, 7));
        }
    }
}