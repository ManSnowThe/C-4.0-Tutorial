// Простая сервисная программа ввода с клавиатуры и вывода на диск,
// демонстрирующая применение класса StreamWriter.
using System;
using System.IO;

namespace ca2
{
    class KToD
    {
        static void Main()
        {
            string str;
            FileStream fout;

            // Открыть сначала поток файлового ввода-вывода.
            try
            {
                fout = new FileStream("test.txt", FileMode.Create);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка открытия файла:\n " + exc.Message);
                return;
            }

            // Заключить поток файлового ввода-вывода в оболочку класса StreamWriter
            StreamWriter fstr_out = new StreamWriter(fout);

            try
            {
                Console.WriteLine("Введите текст, а по окончании - 'стоп'.");
                do
                {
                    Console.Write(": ");
                    str = Console.ReadLine();

                    if (str != "стоп")
                    {
                        str = str + "\r\n"; // добавить новую строку
                        fstr_out.Write(str);
                    }
                }
                while (str != "стоп");
            }
            catch(IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }
            finally
            {
                fstr_out.Close();
            }
        }
    }
}
