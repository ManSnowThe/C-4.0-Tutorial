using System;

namespace ca2
{
    class WhileDemo
    {
        static void Main()
        {
            int e;
            int result;
            int k;
            string s;

            s=Console.ReadLine();
            k = Convert.ToInt32(s);

            for(int i=1; i<10; i++)
            {
                result = 1;
                e = i;
                
                while (e > 0)
                {
                    result *= k;
                    e--;
                }
                Console.WriteLine(k+ " в степени " + i + " равно " + result);
            }
        }
    }
}
