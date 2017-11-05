// Пример простых часов.
using System;

namespace ca2
{
    class SimpleClock
    {
        static void Main()
        {
            string t;
            int seconds;

            DateTime dt = DateTime.Now;
            seconds = dt.Second;

            for (;;)
            {
                dt = DateTime.Now;

                // обновлять время через каждую секунду
                if (seconds != dt.Second)
                {
                    seconds = dt.Second;

                    t = dt.ToString("T");

                    if (dt.Minute == 0 && dt.Second == 0)
                        t = t + "\a"; // производить звонок через каждый час

                    // Console.Clear();
                    Console.WriteLine(t);
                }
            }
        }
    }
}
