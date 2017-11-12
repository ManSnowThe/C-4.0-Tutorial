// Использовать объекты типа ParallelLoopResult и ParallelLoopState, а также
// метод Break() вместе с методом ForEach() для параллельного выполнения цикла.
using System;
using System.Threading.Tasks;

namespace ca2
{
    class DemoParallelForWithLoopResult
    {
        static int[] data;

        // Метод, служащий в качестве тела параллельно выполняемого цикла.
        // В данном примере переменной v передается значение элемента массива
        // данных, а не индекс этого элемента.
        static void DisplayData(int v, ParallelLoopState pls)
        {
            // Прервать цикл при обнаружении отрицательного значения.
            if (v < 0) pls.Break();

            Console.WriteLine("Значение: " + v);
        }
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");

            data = new int[100000000];

            // Инициализировать данные.
            for (int i = 0; i < data.Length; i++) data[i] = i;

            // Поместить отрицательное значение в массив data,
            data[100000] = -10;

            // Использовать цикл, параллельно выполняемый методом ForEach(),
            // для отображения данных на экране.
            ParallelLoopResult loopResult = Parallel.ForEach(data, DisplayData);


            // Использовать цикл, параллельно выполняемый методом ForEach(),
            // для отображения данных на экране.
            /*ParallelLoopResult loopResult =
            Parallel.ForEach(data, (v, pls) =>
            {
                Console.WriteLine("Значение: " + v);
                if (v < 0) pls.Break();
            });
            */
            

            // Проверить, завершился ли цикл.
            if (!loopResult.IsCompleted)
                Console.WriteLine("\nЦикл завершился преждевременно из-за того, что обнаружено отрицательное значение" +
                "на шаге цикла номер " + loopResult.LowestBreakIteration + ".\n");

            Console.WriteLine("Основной поток завершен.");        }
    }
}
