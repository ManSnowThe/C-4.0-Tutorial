//Дано целое число NN (>2>2). Последовательность целых чисел AK определяется следующим образом: 
//A1=1,A2=2,A3=3,AK=AK−1+AK−2−2∗AK−3,K=4,5,... 
//Вывести элементы A1,A2,...,AN.

using System;

namespace ca2
{
    class for123
    {
        static void Main()
        {
            int k, n, a1, a2, a3, ak;
            a1 = 1;
            a2 = 2;
            a3 = 3;
            k = 6;
            for(n=4; n<=k; n++)
            {
                ak = a3 + a2 - 2 * a1;
                Console.WriteLine("A{0}={1}", n, ak);
                a1 = a2;
                a2 = a3;
                a3 = ak;
            }
        }
    }
}