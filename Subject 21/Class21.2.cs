/* Рассчитать первоначальные капиталовложения, необходимые
для получения заданной будущей стоимости, исходя из
годовой нормы прибыли и количества лет. */
using System;

namespace ca2
{
    class InitialInvestment
    {
        static void Main()
        {
            decimal initInvest; // первоначальные капиталовложения
            decimal futVal; // будущая стоимость

            double numYears; // количество лет
            double intRate; // годовая норма прибыли

            string str;

            Console.Write("Введите будущую стоимость: ");
            str = Console.ReadLine();
            try
            {
                futVal = Decimal.Parse(str);
            }
            catch(FormatException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            Console.Write("Введите норму прибыли (например, 0.085): ");
            str = Console.ReadLine();
            try
            {
                intRate = Double.Parse(str);
            }
            catch (FormatException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            Console.Write("Введите количество лет: ");
            str = Console.ReadLine();
            try
            {
                numYears = Double.Parse(str);
            }
            catch (FormatException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            initInvest = futVal / (decimal)Math.Pow(intRate + 1.0, numYears);
            Console.WriteLine("Необходимые первоначальные капиталовложения: {0:C}", initInvest);
        }
    }
}
