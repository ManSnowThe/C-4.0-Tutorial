// Использовать два параметра типа out.
using System;


namespace ca2
{
    class Num
    {
        /* Определить, имеется ли у числовых значений переменных х и y
общий множитель. Если имеется, то возвратить наименьший и
наибольший множители посредством параметров типа out. */
public bool HasComFactor(int x, int y, out int least, out int greatest)
        {
            int i;
            int max = x < y ? x : y;
            bool first = true;

            least = 1;
            greatest = 1;
            // Найти наименьший и наибольший общий множитель.
            for(i=2; i<=max/2+1; i++)
            {
                if (((y % i) == 0) & ((x % i) == 0)){
                if (first)
                {
                    least = i;
                    first = false;
                }
                greatest = i;
            }
            }
            if (least != 1) return true;
            else return false;
        }
    }
    class DemoOut
    {
        static void Main()
        {
            Num ob = new ca2.Num();
            int lcf, gcf;

            if(ob.HasComFactor(231,105, out lcf, out gcf))
            {
                Console.WriteLine("Наименьший общий множитель " +
"чисел 231 и 105 равен " + lcf);
                Console.WriteLine("Наибольший общий множитель " +
                "чисел 231 и 105 равен " + gcf);
            }
            else Console.WriteLine("Общий множитель у чисел 231 и 105 отсутствует.");

            if (ob.HasComFactor(35, 51, out lcf, out gcf))
            {
                Console.WriteLine("Наименьший общий множитель " +
                "чисел 35 и 51 равен " + lcf);
                Console.WriteLine("Наибольший общий множитель " +
                "чисел 35 и 51 равен " + gcf);
            }
            else
                Console.WriteLine("Общий множитель у чисел 35 и 51 отсутствует.");

        }
    }
}
