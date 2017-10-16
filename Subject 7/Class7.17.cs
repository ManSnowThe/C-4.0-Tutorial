// Вывести отдельные цифры целого числа словами.
using System;

namespace ca2
{
    class ConvertDigitsToWords
    {
        static void Main()
        {
            int num;
            int nextdigit;
            int numdigits;
            int[] n = new int[20];
            string[] digits = { "нуль", "один", "два",
"три", "четыре", "пять",
"шесть", "семь", "восемь",
"девять" };

            num = 1908;
            Console.WriteLine("Число: " + num);
            Console.Write("Число словами: ");
            nextdigit = 0;
            numdigits = 0;

            // Получить отдельные цифры и сохранить их в массиве n.
            // Эти цифры сохраняются в обратном порядке.
            do
            {
                nextdigit = num % 10;
                n[numdigits] = nextdigit;
                numdigits++;
                num = num / 10;
            }
            while (num > 0);
            numdigits--;

            // Вывести полученные слова.
            for (; numdigits >= 0; numdigits--)
                Console.Write(digits[n[numdigits]] + " ");

        }
    }
}
