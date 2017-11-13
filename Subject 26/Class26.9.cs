// Пример составления документирующих комментариев.
using System;

namespace ca2
{
    /** <remarks>
     * Это пример многострочного документирования в формате XML.
     * В классе Test демонстрируется ряд дескрипторов.
    </remarks>
    */
    class Test
    {
        ///<summary>
        /// Выполнение программы начинается с метода Main().
        /// </summary>
        static void Main()
        {
            int sum;

            sum = Summation(5);
            Console.WriteLine("Сумма последовательных чисел " + 5 + " равна " + sum);
        }

        /// <summary>
        /// Метод Summation() возвращает сумму его аргументов.
        /// <param name = "val">
        /// Суммируемое значение передается в качестве параметра val.
        /// </param>
        /// <see cref="int"> </see>
        /// <returns>
        /// Сумма возвращается в виде значения типа int.
        /// </returns>
        /// </summary>
        static int Summation(int val)
        {
            int result = 0;

            for (int i = 1; i <= val; i++)
                result += i;

            return result;
        }
    }
}
