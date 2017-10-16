// Продемонстрировать применение оператора typeof.
using System;
using System.IO;

namespace ca2
{
    class UseTypeof
    {
        static void Main()
        {
            Type t = typeof(StreamReader);

            Console.WriteLine(t.FullName);

            if (t.IsClass) Console.WriteLine("Относится к классу.");
            if (t.IsAbstract) Console.WriteLine("Является абстрактным классом.");
            else Console.WriteLine("Является конкретным классом.");
        }
    }
}
