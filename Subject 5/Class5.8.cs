using System;

namespace ca2
{
    class Class5
    {
        static void Main()
        {
            int num, nextdigit;

            num = 198;
            Console.WriteLine("Число " + num);
            Console.Write("Число в обратном порядке: ");

            do
            {
                nextdigit = num % 10;
                Console.Write(nextdigit);
                num = num / 10;
            }
            while (num > 0);
            Console.WriteLine();
        }
    }
}
