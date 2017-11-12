// Продемонстрировать применение класса Stack.
using System;
using System.Collections;

namespace ca2
{
    class StackDemo
    {
        static void ShowPush(Stack st, int a)
        {
            st.Push(a);
            Console.WriteLine("Поместить в стек: Push(" + a + ")");
            Console.Write("Содержимое стека: ");
            foreach (int i in st)
                Console.Write(i + " ");

            Console.WriteLine();
        }
        static void ShowPop(Stack st)
        {
            Console.WriteLine("Извлечь из стека: Pop -> ");
            int a = (int)st.Pop();
            Console.WriteLine(a);

            Console.WriteLine("Содержимое стека: ");
            foreach (int i in st)
                Console.Write(i + " ");

            Console.WriteLine();
        }
        static void Main()
        {
            Stack st = new Stack();

            foreach (int i in st)
                Console.Write(i + " ");

            Console.WriteLine();

            ShowPush(st, 22);
            ShowPush(st, 65);
            ShowPush(st, 91);
            ShowPop(st);
            ShowPop(st);
            ShowPop(st);

            try
            {
                ShowPop(st);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Стек пуст.");
            }
        }
    }
}
