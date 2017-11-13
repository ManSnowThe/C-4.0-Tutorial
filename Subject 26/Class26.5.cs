/* Пример проверки cookie-наборов.
Для того чтобы проверить, какие именно cookie-наборы
используются на веб-сайте, укажите его имя в командной строке.
Так, если назвать эту программу CookieDemo, то по команде
      CookieDemo http://msn.com
отобразятся cookie-наборы с веб-сайта по адресу www.msn.com. */
using System;
using System.Net;

namespace ca2
{
    class CookieDemo
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Применение: CookieDemo <uri>");
                return;
            }
            // Создать объект запроса типа WebRequest по указанному URI.
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(args[0]);

            // Получить пустой контейнер
            req.CookieContainer = new CookieContainer();

            // Отправить сформированный запрос и получить на него ответ.
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            // Отобразить cookie-наборы.
            Console.WriteLine("Количество cookie-наборов: " + resp.Cookies.Count);

            Console.WriteLine("{0,-20}{1}", "Имя", "Значение");
            for (int i = 0; i < resp.Cookies.Count; i++)
                Console.WriteLine("{0,-20}{1}", resp.Cookies[i].Name, resp.Cookies[i].Value);

            // Закрыть ответный поток.
            resp.Close();
        }
    }
}
