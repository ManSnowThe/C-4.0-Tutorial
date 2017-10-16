// Продемонстрировать применение классов StringReader и StringWriter.using System;
using System.IO;

namespace ca2
{
    class StrRdrWtrDemo
    {
        static void Main()
        {
            StringWriter strwtr = null;
            StringReader strrdr = null;

            try
            {
                // Создать объект класс StringWriter
                strwtr = new StringWriter();

                // Вывести данные в записывающий поток типа StringWriter.
                for (int i = 0; i < 10; i++)
                    strwtr.WriteLine("Значение i равно: " + i);

                // Создать объект класса StringReader.
                strrdr = new StringReader(strwtr.ToString());

                // А теперь ввести данные из считывающего потока типа StringReader.
                string str = strrdr.ReadLine();
                while(str != null)
                {
                    str = strrdr.ReadLine();
                    Console.WriteLine(str);
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода\n" + exc.Message);
            }
            finally
            {
                // Освободить ресурсы считывающего и записывающего потоков.
                if (strrdr != null) strrdr.Close();
                if (strwtr != null) strwtr.Close();
            }
        }
    }
}
