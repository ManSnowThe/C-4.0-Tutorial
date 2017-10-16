/* Скопировать файл, используя метод File.Copy().
Чтобы воспользоваться этой программой, укажите имя исходного и целевого
файлов. Например, чтобы скопировать файл FIRST.DAT в файл SECOND.DAT,
введите в командной строке следующее:
CopyFile FIRST.DAT SECOND.DAT
*/
using System;
using System.IO;

namespace ca2
{
    class CopyFile
    {
        static void Main(string[] args)
        {
            if (args.Length != 2) {
                Console.WriteLine("Применение: CopyFile Откуда Куда");
                return;
            }
            // Копировать файлы.
            try
            {
                File.Copy(args[0], args[1]);
            }
            catch(IOException exc)
            {
                Console.WriteLine("Ошибка копирования файла\n" + exc.Message);
            }
        }
    }
}
