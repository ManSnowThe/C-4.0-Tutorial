//Ниже приведена программа, в которой принцип постоянства строк демонстри­
//руется на примере использования метода Substring().
using System;

namespace ca2
{
    class SubStr
    {
        static void Main()
        {
            string orgstr = "В C# упрощается обращение со строками";

            // сформировать подстроку
            string substr = orgstr.Substring(5, 20);

            Console.WriteLine("orgstr: " + orgstr);
            Console.WriteLine("substr: " + substr);
        }
    }
}
