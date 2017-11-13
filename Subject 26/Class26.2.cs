// Пример обработки сетевых исключений.
using System;
using System.Net;
using System.IO;

namespace ca2
{
    class NetDemo
    {
        static void Main()
        {
            int ch;

            try
            {
                // Сначала создать объект запроса типа WebRequest по указанному URI.
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://www.vk.com/unrealsite");

                // Затем отправить сформированный запрос и получить на него ответ.
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                // Получить из ответа поток ввода.
                Stream istrm = resp.GetResponseStream();

                /* А теперь прочитать и отобразить гипертекстовое содержимое,
                 * полученное по указанному URI. Это содержимое выводится на экран
                 * отдельными порциями по 400 символов. После каждой такой порции
                 * следует нажать клавишу <ENTER>, чтобы вывести на экран             * следующую порцию из 400 символов. */
                for (int i = 1; ; i++)
                {
                    ch = istrm.ReadByte();
                    if (ch == -1) break;
                    Console.Write((char)ch);
                    if ((i % 400) == 0)
                    {
                        Console.Write("\nНажмите клавишу <Enter>.");
                        Console.ReadLine();
                    }
                }
                // Закрыть ответный поток. При этом закрывается также поток ввода istrm.
                resp.Close();
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
            catch (System.Security.SecurityException exc)
            {
                Console.WriteLine("Исключение в связи с нарушением безопасности: " + exc.Message);
            }
            catch (InvalidOperationException exc)
            {
                Console.WriteLine("Недопустимая операция: " + exc.Message);
            }
        }
    }
}
