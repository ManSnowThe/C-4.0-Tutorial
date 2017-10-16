// Эта программа усредняет ряд чисел, вводимых пользователем.
using System;
using System.IO;

namespace ca2
{
    class AvgNums
    {
        static void Main()
        {
            string str;
            int n;
            double sum = 0.0;
            double avg, t;

            Console.Write("Сколько чисел вы собираетесь ввести: ");
            str = Console.ReadLine();
            try
            {
                n = Int32.Parse(str);
            }
            catch(FormatException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            catch(OverflowException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }

            Console.WriteLine("Введите " + n + " чисел.");
            for(int i=0; i<n; i++)
            {
                Console.Write(": ");
                str = Console.ReadLine();

                try
                {
                    t = Double.Parse(str);
                }
                catch(FormatException exc)
                {
                    Console.WriteLine(exc.Message);
                    t = 0.0;
                }
                catch(OverflowException exc)
                {
                    Console.WriteLine(exc.Message);
                    t = 0;
                }
                sum += t;
            }
            avg = sum / n;
            Console.WriteLine("Среднее равно " + avg);
        }
    }
}