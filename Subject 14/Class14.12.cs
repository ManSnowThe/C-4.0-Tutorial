// Простая сервисная программа ввода с диска и вывода на экран,
// демонстрирующая применение класса StreamReader.
using System;
using System.IO;

namespace ca2
{
    class DToS
    {
        static void Main()
        {
            FileStream fin;
            string s;

            try
            {
                fin = new FileStream("test.txt", FileMode.Open);
            }
            catch(IOException exc)
            {
                Console.WriteLine("Ошибка открытия файла:\n" + exc.Message);
                return;
            }

            StreamReader fstr_in = new StreamReader(fin);

            try
            {
                while ((s = fstr_in.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                /*
                while (!fstr_in.EndOfStream)
                {
                    s = fstr_in.ReadLine();
                    Console.WriteLine(s);
                }                */
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }
            finally
            {
                fstr_in.Close();
            }
        }
    }
}
