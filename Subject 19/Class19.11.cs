// Продемонстрировать применение оператора group.
using System;
using System.Linq;

namespace ca2
{
    class GroupDemo
    {
        static void Main()
        {
            string[] websites =
            {
                "hsNameA.com", "hsNameB.net", "hsNameC.net",
                "hsNameD.com", "hsNameE.org", "hsNameF.org",
                "hsNameG.tv", "hsNameH.net", "hsNameI.tv"            };
            // Сформировать запрос на получение списка веб-сайтов,
            // группируемых по имени домена самого верхнего уровня.
            var webAddrs = from addr in websites
                           where addr.LastIndexOf('.') != -1
                           group addr by addr.Substring(addr.LastIndexOf('.'));

            // Выполнить запрос и вывести его результаты.
            foreach (var sites in webAddrs) // foreach(IGrouping<string, string> sites in webAddrs)
            {
                Console.WriteLine("Веб-сайты, сгруппированные по имени домена " + sites.Key);
                foreach (var site in sites) // foreach(string site in sites)
                    Console.WriteLine(" " + site);
                Console.WriteLine();
            }
        }
    }
}
