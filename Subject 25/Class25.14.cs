// Продемонстрировать применение класса Stack<T>.
using System;
using System.Collections.Generic;

namespace ca2
{
    class GenStackDemo
    {
        static void Main()
        {
            Stack<string> st = new Stack<string>();

            st.Push("один");
            st.Push("два");
            st.Push("три");
            st.Push("четыре");
            st.Push("пять");

            while (st.Count > 0)
            {
                string str = st.Pop();
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }
    }
}
