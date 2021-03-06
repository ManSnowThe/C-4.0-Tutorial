﻿// Простой запрос PLINQ.
using System;
using System.Linq;

namespace ca2
{
    class PLINQDemo
    {
        static void Main()
        {
            int[] data = new int[10000000];

            // Инициализировать массив данных положительными значениями.
            for (int i = 0; i < data.Length; i++) data[i] = i;

            // А теперь ввести в массив данных ряд отрицательных значений.
            data[1000] = -1;
            data[14000] = -2;
            data[15000] = -3;
            data[676000] = -4;
            data[8024540] = -5;
            data[9908000] = -6;

            // Использовать запрос PLINQ для поиска отрицательных значений.
            var negatives = from val in data.AsParallel().AsOrdered()
                            where val < 0
                            select val;

            foreach (var v in negatives)
                Console.Write(v + " ");

            Console.WriteLine();
        }
    }
}
