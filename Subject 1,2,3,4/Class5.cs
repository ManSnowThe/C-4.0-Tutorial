//Применение тригонометрических функций

using System;

namespace ca2
{
    class trigonometry
    {
        static void Main()
        {
            double corner; // угол в радианах

            for (corner = 0.1; corner <= 1.0; corner = corner + 0.1)
            {
                Console.WriteLine("Синус   угла " + corner + " равен " + Math.Sin(corner));
                Console.WriteLine("Косинус угла " + corner + " равен " + Math.Cos(corner));
                Console.WriteLine("Тангенс угла " + corner + " равен " + Math.Tan(corner));
                Console.WriteLine();
            }

        }
    }
}