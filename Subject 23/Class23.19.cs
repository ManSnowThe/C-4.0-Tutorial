// Продемонстрировать запуск нового процесса.
using System;
using System.Diagnostics;

namespace ca2
{
    class StartProcess
    {
        static void Main()
        {
            Process newProc = Process.Start("wordpad.exe");

            Console.WriteLine("Новый процесс запущен.");

            newProc.WaitForExit();

            newProc.Close(); // освободить выделенные ресурсы.

            Console.WriteLine("Новый процесс завершен.");
        }
    }
}
