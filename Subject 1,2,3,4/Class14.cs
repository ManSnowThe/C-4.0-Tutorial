//Пример приведения типов в выражениях
using System;
namespace ca2
{
class CastExpr
{
    static void Main()
    {
            double n;
            
            for(n=1.0; n <= 10; n++)
            {
                Console.WriteLine("Квадратный корень из {0} равен {1}", n, Math.Sqrt(n));
                Console.WriteLine("Целая часть числа: {0} ", (int)Math.Sqrt(n));
                Console.WriteLine("Дробная часть числа: {0} ", Math.Sqrt(n) - (int)Math.Sqrt(n));
                Console.WriteLine();
            }  
    }
}
}