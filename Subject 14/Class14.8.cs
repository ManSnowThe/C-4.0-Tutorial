// Записать данные в файл.
using System;
using System.IO;

namespace ca2
{
    class WriteToFile
    {
        static void Main(string[] args)
        {
            FileStream fout = null;

            try
            {
                // Открыть выходной файл.
                fout = new FileStream("test1.txt", FileMode.CreateNew);

                // Записать весь английский алфавит в файл.
                for (char c = 'A'; c <= 'Z'; c++)
                    fout.WriteByte((byte)c);
            }
            catch(IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }
            finally
            {
                if (fout != null) fout.Close();
            }
        }
    }
}
