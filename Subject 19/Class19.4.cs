// Продемонстрировать применение еще одного оператора where.
using System;
using System.Linq;

namespace ca2
{
    class WhereDemo2
    {
        static void Main()
        {
            string[] strs =  { ".com", ".net", "hsNameA.com", "hsNameB.net", "test",
                              ".network", "hsNameC.net", "hsNameD.com" };
            // Сформировать запрос на получение адресов
            // Интернета, оканчивающихся на .net.
            var netAddrs = from addr in strs
                           where addr.Length > 4 && addr.EndsWith(".net", StringComparison.Ordinal)
                           select addr;

            // Выполнить запрос и вывести его результаты.
            foreach (var str in netAddrs) Console.WriteLine(str);
        }
    }
}
