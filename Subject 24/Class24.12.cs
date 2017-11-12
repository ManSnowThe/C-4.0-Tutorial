// Продемонстрировать отличия во времени последовательного
// и параллельного выполнения цикла for.
using System;
using System.Threading.Tasks;
using System.Diagnostics;

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
            if (data[i] < 1000) data[i] = 0;
            if (data[i] > 1000 & data[i] < 2000) data[i] = 100;
            if (data[i] > 2000 & data[i] < 3000) data[i] = 200;
            if (data[i] > 3000) data[i] = 300;
        }
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");

            // Создать экземпляр объекта типа Stopwatch
            // для хранения времени выполнения цикла.
            Stopwatch sw = new Stopwatch();

            data = new int[100000000];

            // Инициализировать данные.
            sw.Start();
            // Параллельный вариант инициализации массива в цикле.
            Parallel.For(0, data.Length, (i) => data[i] = i);
            sw.Stop();

            Console.WriteLine("Параллельно выполняемый цикл инициализации: {0} секунд", sw.Elapsed.TotalSeconds);

            sw.Reset();

            sw.Start();
            // Последовательный вариант инициализации массива в цикле.
            for (int i = 0; i < data.Length; i++) data[i] = i;
            sw.Stop();

            Console.WriteLine("Последовательно выполняемый цикл инициализации: {0} секунд", sw.Elapsed.TotalSeconds);

            Console.WriteLine();

            // Выполнить преобразования.
            sw.Start();
            // Параллельный вариант преобразования данных в цикле.
            Parallel.For(0, data.Length, MyTransform);
            sw.Stop();

            Console.WriteLine("Параллельно выполняемый цикл преобразования: {0} секунд", sw.Elapsed.TotalSeconds);

            sw.Reset();

            sw.Start();
            // Последовательный вариант преобразования данных в цикле.
            for (int i = 0; i < data.Length; i++) MyTransform(i);
            sw.Stop();

            Console.WriteLine("Последовательно выполняемый цикл преобразования: {0} секунд", sw.Elapsed.TotalSeconds);

            Console.WriteLine("Основной поток завершен.");
        }
    }
}
