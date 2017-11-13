// Проверить заголовки.
using System;
using System.Net;

namespace ca2
{
    class HeaderDemo
    {
        static void Main()
        {
            // Создать объект запроса типа WebRequest по указанному URI.
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://www.youtube.com");

            // Отправить сформированный запрос и получить на него ответ.
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            // Получить список имен.
            string[] names = resp.Headers.AllKeys;

            // Отобразить пары "имя-значение" из заголовка.
            Console.WriteLine("{0,-20}{1}\n", "Имя", "Значение");
            foreach(string n in names)
            {
                Console.Write("{0,-20}", n);
                foreach (string v in resp.Headers.GetValues(n))
                    Console.WriteLine(v);
            }
            // Закрыть ответный поток.
            resp.Close();
        }
    }
}
