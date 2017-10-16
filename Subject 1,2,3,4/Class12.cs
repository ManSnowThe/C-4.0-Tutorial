//Продемонстрировать время существования переменной
using System;

namespace ca2
{
    class VarInitDemo
    {
        static void Main()
        {
            int x;

            for(x=0; x<3; x++)
            {
               int y = -1; // Переменная y инициализируется при каждом входе в блок
                Console.WriteLine("y равно: " + y); //Здесь всегда выводится -1

                y = 100;
                Console.WriteLine("y теперь равно: " + y);
            }
        }
    }
}