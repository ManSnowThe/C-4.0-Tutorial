// Выяснить, является ли число простым. Если оно
// непростое, вывести наибольший его множитель.

using System;

namespace ca2
{
    class FindPrimes
    {
        static void Main()
        {
            int num, i, factor;
            bool isprime;

            for (num = 2; num < 30; num++)
            {
                isprime = true;
                factor = 0;

                //Выяснить, делиться значение переменной num нацело.
                for(i=2; i <= num / 2; i++)
                {
                    if ((num % i) == 0)
                    {

                        // Значение переменной num делится нацело.
                        // Следовательно, это непростое число.

                        isprime = false;
                        factor = i;
                    }
                    
                }
                if (isprime)
                    Console.WriteLine(num + " - простое число");
                else
                    Console.WriteLine("Наибольший множитель числа " + num + " равен " + factor);
            }
        }
    }
}
