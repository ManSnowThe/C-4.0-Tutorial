﻿// Отобразить содержимое текстового файла.
using System;
using System.IO;

namespace ca2
{
    class ShowFile
    {
        static void Main(string[] args)
        {
            int i;
            FileStream fin = null;

            if (args.Length != 1)
            {
                Console.WriteLine("Применение: ShowFile File");
                return;
            }
            try
            {
                fin = new FileStream(args[0], FileMode.Open);
                // Читать байты до конца файла.
                do
                {
                    i = fin.ReadByte();
                    if (i != -1) Console.Write((char)i);
                }
                while (i != -1);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }
            finally
            {
                if (fin != null) fin.Close();
            }
        }
    }
}