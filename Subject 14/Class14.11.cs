// Открыть файл средствами класса StreamWriter.
using System;
using System.IO;

namespace ca2
{
    class KToD
    {
        static void Main()
        {
            string str;
            StreamWriter fstr_out = null;

            try
            {
                // Открыть файл, заключенный в оболочку StreamWriter.
                fstr_out = new StreamWriter("test.txt");

                Console.WriteLine("Введите текст, а по окончании — 'стоп'.");
                do
                {
                    Console.Write(" : ");
                    str = Console.ReadLine();

                    if (str != "стоп")
                    {
                        str = str + "\r\n";
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
                if (fstr_out != null)
                    fstr_out.Close();
            }
        }
    }
}
