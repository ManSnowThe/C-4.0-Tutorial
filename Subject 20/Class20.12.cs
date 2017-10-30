// Использовать обнуляемые объекты в выражениях.using System;

namespace ca2
{
    class NullableDemo
    {
        static void Main()
        {
            int? count = null;
            int? result = null;

            int incr = 10; // переменная incr не является обнуляемой

            // переменная result содержит пустое значение.
            // переменная count оказывается пустой.
            result = count + incr;
            if (result.HasValue)
                Console.WriteLine("Переменная result имеет следующее значение: " + result.Value);
            else
                Console.WriteLine("У переменной result отсутствует значение");

            // Теперь переменная count получает свое значение, и поэтому
            // переменная result будет содержать конкретное значение.
            count = 100;
            result = count + incr;
            if (result.HasValue)
                Console.WriteLine("Переменная result имеет следующее значение: " + result.Value);
            else
                Console.WriteLine("У переменной result отсутствует значение");
        }
    }
}
