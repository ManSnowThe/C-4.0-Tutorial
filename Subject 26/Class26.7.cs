/* MiniCrawler: скелетный вариант поискового робота.
Применение: для запуска поискового робота укажите URI
в командной строке. Например, для того чтобы начать поиск
с адреса www.McGraw-Hill.com, введите следующую команду:
        MiniCrawler http://McGraw-Hill.com
*/
using System;
using System.Net;
using System.IO;

namespace ca2
{
    class MiniCrawler
    {
        // Найти ссылку в строке содержимого.
        static string FindLink(string htmlstr, ref int starloc)
        {
            int i;
            int start, end;
            string uri = null;

            i = htmlstr.IndexOf("href=\"http", starloc, StringComparison.OrdinalIgnoreCase);

            if (i != -1)
            {
                start = htmlstr.IndexOf('"', i) + 1;
                end = htmlstr.IndexOf('"', start);
                uri = htmlstr.Substring(start, end - start);
                starloc = end; 
            }
            return uri;
        }
        static void Main(string[] args)
        {
            string link = null;
            string str;
            string answer;

            int curlock; // содержит текущее положение в ответе
            if (args.Length != 1)
            {
                Console.WriteLine("Применение: MiniCrawler <uri>");
                return;
            }
            string uristr = args[0]; // содержит текущий URI

            HttpWebResponse resp = null;

            try
            {
                do
                {
                    Console.WriteLine("Переход по ссылке " + uristr);

                    // Создать объект запроса типа WebRequest по указанному URI.
                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uristr);

                    uristr = null; // запретить дальнейшее использование этого URI

                    // Отправить сформированный запрос и получить на него ответ.
                    resp = (HttpWebResponse)req.GetResponse();

                    // Получить поток ввода из принятого ответа.
                    Stream istrm = resp.GetResponseStream();

                    // Заключить поток ввода в оболочку класса StreamReader.
                    StreamReader rdr = new StreamReader(istrm);

                    // Прочитать всю страницу.
                    str = rdr.ReadToEnd();

                    curlock = 0;

                    do
                    {
                        // Найти следующий URI для перехода по ссылке.
                        link = FindLink(str, ref curlock);

                        if (link != null)
                        {
                            Console.WriteLine("Найдена ссылка: " + link);

                            Console.Write("Перейти по ссылке, Искать дальше, Выйти?");
                            answer = Console.ReadLine();

                            if (string.Equals(answer, "П", StringComparison.OrdinalIgnoreCase))
                            {
                                uristr = string.Copy(link);
                                break;
                            }
                            else if (string.Equals(answer, "В", StringComparison.OrdinalIgnoreCase))
                            {
                                break;
                            }
                            else if (string.Equals(answer, "И", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Поиск следующей ссылки.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Больше ссылок не найдено.");
                            break;
                        }
                    }
                    while (link.Length > 0);

                    // Закрыть ответный поток.
                    if (resp != null) resp.Close();
                }
                while (uristr != null);
            }
            catch (WebException exc)
            {
                Console.WriteLine("Сетевая ошибка: " + exc.Message + "\nКод состояния: " + exc.Status);
            }
            catch (ProtocolViolationException exc)
            {
                Console.WriteLine("Протокольная ошибка: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                Console.WriteLine("Ошибка формата URI: " + exc.Message);
            }
            catch (NotSupportedException exc)
            {
                Console.WriteLine("Неизвестный протокол: " + exc.Message);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода: " + exc.Message);
            }
            finally
            {
                if (resp != null) resp.Close();
            }
            Console.WriteLine("Завершение программы MiniCrawler.");
        }
    }
}
