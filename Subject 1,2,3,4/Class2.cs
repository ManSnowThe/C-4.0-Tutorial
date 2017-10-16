using System;

namespace ca2
{
    class CodeBlockDemo
    {
        static void Main()
        {
            int i, j, d;
            i = 0;
            j = 10;

            if (i != 0)
            {
                Console.WriteLine("i не равен 0");
                d = j / i;
                Console.WriteLine("j / i равно " +d);
            }

            if (i == 0)
            {
                Console.WriteLine("i равен 0");
                d = j + i;
                Console.WriteLine("j равен " + d);
            }
        }
    }
}
