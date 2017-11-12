// Применить метод Parallel.For() для организации параллельно
// выполняемого цикла обработки данных.
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ca2
{
    class DemoParallelFor
    {
        static int[] data;

        // Метод, служащий в качестве тела параллельно выполняемого цикла.
        // Операторы этого цикла просто расходуют время ЦП для целей демонстрации.
        static void MyTransform(int i)
        {
            data[i] = data[i] / 10;

            if (data[i] < 10000) data[i] = 0;
            if (data[i] > 10000 & data[i] < 20000) data[i] = 100;
            if (data[i] > 20000 & data[i] < 30000) data[i] = 200;
            if (data[i] > 30000) data[i] = 300;
        }
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");

            data = new int[100000000];

            // Инициализировать данные в обычном цикле for.
            for (int i = 0; i < data.Length; i++) data[i] = i;

            // Распараллелить цикл методом For().
            Parallel.For(0, data.Length, MyTransform);

            Console.WriteLine("Основной поток завершен.");
        }
    }
}
