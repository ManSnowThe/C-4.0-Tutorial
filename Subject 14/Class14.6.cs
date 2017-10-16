/* Отобразить содержимое текстового файла.
Чтобы воспользоваться этой программой, укажите имя того файла,
содержимое которого требуется отобразить. Например, для просмотра
содержимого файла TEST.CS введите в командной строке следующее:
ShowFile TEST.CS
*/using System;
using System.IO;

namespace ca2
{
    class ShowFile
    {
        static void Main(string[] args)
        {
            int i;
            FileStream fin;

            if (args.Length != 1)
            {
                Console.WriteLine("Применение: ShowFile Файл");
                return;
            }
            try
            {
                fin = new FileStream(args[0], FileMode.Open);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Не удается открыть файл.");
                Console.WriteLine(exc.Message);
                return; // Файл не открывается, завершить программу.
            }

            // Читать байты до конца файла
            try
            {
                do
                {
                    i = fin.ReadByte();
                    if (i != -1) Console.Write((char)i);
                }
                while (i != -1);
            }
            catch(IOException exc)
            {
                Console.WriteLine("Ошибка чтения файла");
                Console.WriteLine(exc.Message);
            }
            finally
            {
                fin.Close();
            }
        }
    }
}
