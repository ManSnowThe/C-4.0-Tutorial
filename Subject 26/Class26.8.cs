// Использовать класс WebClient для загрузки данных
// в файл по указанному сетевому адресу.
using System;
using System.Net;
using System.IO;
class WebClientDemo
{
    static void Main()
    {
        WebClient user = new WebClient();
        string uri = "http://www.youtube.com";
        string fname = "data.txt";
        try
        {
            Console.WriteLine("Загрузка данных по адресу " +
            uri + " в файл " + fname);
            user.DownloadFile(uri, fname);
        }
        catch (WebException exc)
        {
            Console.WriteLine(exc);
        }
        Console.WriteLine("Загрузка завершена.");
    }
}