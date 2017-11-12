// Использовать объекты типа ParallelLoopResult и ParallelLoopState, а также
// метод Break() вместе с методом For() для параллельного выполнения цикла.
using System;
using System.Threading.Tasks;

namespace ca2
{
    class DemoParallelForWithLoopResult
    {
        static int[] data;

        // Метод, служащий в качестве тела параллельно выполняемого цикла.
        // Операторы этого цикла просто расходуют время ЦП для целей демонстрации.
        static void MyTransform(int i, ParallelLoopState pls)
        {
            // Прервать цикл при обнаружении отрицательного значения.
            if (data[i] < 0) pls.Break();

            data[i] = data[i] / 10;
            if (data[i] < 1000) data[i] = 0;
            if (data[i] > 1000 & data[i] < 2000) data[i] = 100;
            if (data[i] > 2000 & data[i] < 3000) data[i] = 200;
            if (data[i] > 3000) data[i] = 300;
        }        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");
            data = new int[100000000];

            // Инициализировать данные.
            for (int i = 0; i < data.Length; i++) data[i] = i;

            // Поместить отрицательное значение в массив data.
            data[1000] = -10;

            // Параллельный вариант инициализации массива в цикле.
            ParallelLoopResult loopResult = Parallel.For(0, data.Length, MyTransform);

            // Проверить, завершился ли цикл.
            if (!loopResult.IsCompleted)
                Console.WriteLine("\nЦикл завершился преждевременно из-за того, что обнаружено отрицательное значение" +
                    "на шаге цикла номер " + loopResult.LowestBreakIteration + "\n");

            Console.WriteLine("Основной поток завершен.");
        }
    }
}
