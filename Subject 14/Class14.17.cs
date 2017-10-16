// Продемонстрировать применение класса MemoryStream.using System;
using System.IO;
namespace ca2
{
    class MemStrDemo
    {
        static void Main()
        {
            byte[] storage = new byte[255];

            // Создать запоминающий поток.
            MemoryStream memstrm = new MemoryStream(storage);

            // Заключить объект memstrm в оболочки классов чтения и записи данных в потоки.
            StreamWriter memwtr = new StreamWriter(memstrm);
            StreamReader memrdr = new StreamReader(memstrm);

            try
            {
                // Записать данные в память, используя объект memwtr.
                for (int i = 0; i < 10; i++)
                    memwtr.WriteLine("byte [" + i + "]: " + i);

                // Поставить в конце точку.
                memwtr.WriteLine(".");

                memwtr.Flush();                Console.WriteLine("Чтение прямо из массива storage: ");

                // Отобразить содержимое массива storage непосредственно.
                foreach (char ch in storage)
                {
                    if (ch == '.') break;
                    Console.Write(ch);
                }

                Console.WriteLine("\nЧтение из потока с помощью объекта memrdr: ");
                // Читать из объекта memstrm средствами ввода данных из потока.
                memstrm.Seek(0, SeekOrigin.Begin); // установить указатель файла в исходное положение

                string str = memrdr.ReadLine();
                while (str != null)
                {
                    str = memrdr.ReadLine();
                    if (str[0] == '.') break;
                    Console.WriteLine(str);
                }
            }
            catch(IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода\n" + exc.Message);
            }
            finally
            {
                // Освободить ресурсы считывающего и записывающего потоков.
                memwtr.Close();
                memrdr.Close();
            }
        }
    }
}
