using System;
namespace ca2
{
    class usedecimal
    {
        static void Main()
        {
            decimal amount;
            decimal rate_of_return;
            int years, i;

            amount = 1000.0m;
            rate_of_return = 0.07m;
            years = 10;

            Console.WriteLine("Первоначальные капиталовложения: $" + amount);
            Console.WriteLine("Норма прибыли: " + rate_of_return);
            Console.WriteLine("В течение " + years + " лет");

            for (i = 0; i < years; i++)
                amount = amount + (amount * rate_of_return);

            Console.WriteLine("Будущая стоимость будет равна $" + amount);

        }
    }
}