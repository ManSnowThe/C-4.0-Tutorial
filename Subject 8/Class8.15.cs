// Возвратить массив из метода.
using System;


namespace ca2
{
    class Factor
    {
        /* Метод возвращает массив facts, содержащий множители аргумента num.
При возврате из метода параметр numfactors типа out будет содержать
количество обнаруженных множителей. */
        public int[] FindFactors(int num, out int numfactors)
        {
            int[] facts = new int[80]; // размер массива 80 выбран произвольно
            int i, j;
            // Найти множители и поместить их в массив facts.
            for (i=2, j=0; i<=num/2+1; i++)
            
                if ((num % i) == 0)
                {
                    facts[j] = i;
                    j++;
                }
                numfactors = j;
                return facts;
            
        }
    }
    class FindFactors
    {
        static void Main()
        {
            Factor f = new Factor();
            int numfactors;
            int[] factors;

            factors = f.FindFactors(1000, out numfactors);

            Console.WriteLine("Множители числа 1000: ");
            for (int i = 0; i < numfactors; i++)
                Console.Write(factors[i] + " ");

            Console.WriteLine();
        }
    }
}
