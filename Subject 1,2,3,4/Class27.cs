//Исключить деление на 0, используя оператор ?

using System;
namespace ca2
{
    class NoZeroDiv
    {
        static void Main()
        {
            int result;

            for(int i=-5; i<6; i++)
            {
                result = i != 0 ? 100 / i : 0;
                if (i != 0)
                    Console.WriteLine("100 / " + i + " равно " + result);
            }
        }
    }
}