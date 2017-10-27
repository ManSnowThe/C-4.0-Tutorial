// Продемонстрировать применение метода запроса GroupBy().
// Это переработанный вариант примера, представленного ранее
// для демонстрации синтаксиса запросов.using System;
using System.Linq;

namespace ca2
{
    class GroupByDemo
    {
        static void Main()
        {
            string[] websites =
            {
                "hsNameA.com", "hsNameB.net", "hsNameC.net",
                "hsNameD.com", "hsNameE.org", "hsNameF.org",
                "hsNameG.tv", "hsNameH.net", "hsNameI.tv"            };
            // Использовать методы запроса для группирования
            // веб-сайтов по имени домена самого верхнего уровня.
            var webAddrs = websites.Where(w => w.LastIndexOf('.') != -1).GroupBy(x => x.Substring(x.LastIndexOf(".", x.Length)));

            // Выполнить запрос и вывести его результаты.
            foreach(var sites in webAddrs)
            {
                Console.WriteLine("Веб-сайты, сгруппированные по имени домена " + sites.Key);                foreach (var site in sites)
                    Console.WriteLine(" " + site);
                Console.WriteLine();
            }
        }
    }
}
