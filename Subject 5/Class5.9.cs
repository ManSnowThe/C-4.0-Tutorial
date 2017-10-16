//Применить оператор break во вложенных циклах.

using System;

namespace ca2
{
    class BreakNested
    {
        static void Main()
        {
            for (int i=0; i<3; i++)
            {
                Console.WriteLine("Подсчет во внешнем цикле: " + i);
                Console.Write("Подсчет во внутреннем цикле: ");

                int t = 0;
                while (t < 100)
                {
                    if (t == 10) break;
                    Console.Write(t + " ");
                    t++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Циклы завершены!");
        }
    }
}
