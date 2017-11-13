/* Использовать свойство LastModified.
Для того чтобы проверить дату последнего обновления веб-сайта,
введите его URI в командной строке. Так, если назвать эту программу
LastModifiedDemo, то для проверки даты последней модификации веб-сайта
по адресу www.HerbSchildt.com введите команду
       LastModifiedDemo http://HerbSchildt.com
*/
using System;
using System.Net;

namespace ca2
{
    class LastModifiedDemo
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Применение: LastModifiedDemo <uri>");
                return;
            }
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(args[0]);

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            Console.WriteLine("Последняя модификация: " + resp.LastModified);

            resp.Close();
        }
    }
}
