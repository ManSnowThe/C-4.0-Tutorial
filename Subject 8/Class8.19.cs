// Класс для хранения символов в стеке.
using System;

namespace ca2
{
    class Stack
    {
        // Эти члены класса являются закрытыми.
        char[] stck; // массив, содержащий стек
        int tos; // индекс вершины стека

        // Сконструировать пустой объект класса Stack по заданному размеру стека.
        public Stack(int size)
        {
            stck = new char[size]; // распределить память для стека
            tos = 0;
        }
        // Сконструировать объект класса Stack из существующего стека.
        public Stack(Stack ob)
        {
            // Распределить память для стека
            stck = new char[ob.stck.Length];

            // Скопировать элементы в новый стек
            for (int i = 0; i < ob.tos; i++)
                stck[i] = ob.stck[i];

            // Установить переменную tos для нового стека
            tos = ob.tos;
        }

        // Поместить символы в стек
        public void Push(char ch)
        {
            if (tos == stck.Length)
            {
                Console.WriteLine(" - Стек заполнен");
                return;
            }

            stck[tos] = ch;
            tos++;
        }

        public char Pop()
        {
            if (tos == 0)
            {
                Console.WriteLine(" - Стек пуст");
                return (char) 0;
            }
            tos--;
            return stck[tos];
        }

        // Возвратить значение true, если стек заполнен.
        public bool IsFull()
        {
            return tos == stck.Length;
        }
        // Возвратить значение true, если стек пуст.
        public bool IsEmpty()
        {
            return tos == 0;
        }
        // Возвратить общую емкость стека
        public int Capacity()
        {
            return stck.Length;
        }
        //  Возвратить количество объектов, находящихся в настоящий момент в стеке.
        public int Num()
        {
            return tos;
        }
    }

    class StackDemo
    {
        static void Main()
        {
            Stack stk1 = new Stack(10);
            char ch;
            int i;

            // Поместить ряд символов в stk1
            Console.WriteLine("Поместить символы А-J в стек stk1.");
            for (i = 0; !stk1.IsFull(); i++)
                stk1.Push((char)('A' + i));

            // Создать копию stk1
            Stack stk2 = new Stack(stk1);

            // Вывести содержимое стека stk1
            Console.Write("Содержимое стека stk1: ");
            while (!stk1.IsEmpty())
            {
                ch = stk1.Pop();
                Console.Write(ch);
            }
            Console.WriteLine();
            Console.Write("Содержимое стека stk2: ");
            while (!stk2.IsEmpty())
            {
                ch = stk2.Pop();
                Console.Write(ch);
            }
            Console.WriteLine("\n");

        }
    }

}
