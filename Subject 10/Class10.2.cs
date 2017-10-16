// Перегрузить индексатор массива класса FailSoftArray.
using System;

namespace ca2
{
    class FailSoftArray
    {
        int[] a; // ссылка на базовый массив

        public int Length; // открытая переменная длины массива
        public bool ErrFlag; // обозначает результат последней операции
                             // Построить массив заданного размера.
        public FailSoftArray(int size)
        {
            a = new int[size];
            Length = size;
        }
        // Это индексатор типа int для массива FailSoftArray.
        public int this[int index]
        {
            // Это аксессор get.
            get
            {
                if (ok(index))
                {
                    ErrFlag = false;
                    return a[index];
                }
                else
                {
                    ErrFlag = true;
                    return 0;
                }
            }
            // Это аксессор set.
            set
            {
                if (ok(index))
                {
                    a[index] = value;
                    ErrFlag = false;
                }
                else ErrFlag = true;
            }
        }
        /* Это еще один индексатор для массива FailSoftArray.
        Он округляет свой аргумент до ближайшего целого индекса. */
        public int this[double idx]
        {
            // Это аксессор get.
            get
            {
                int index;
                // Округлить до ближайшего целого.
                if ((idx - (int)idx) < 0.5) index = (int)idx;
                else index = (int)idx + 1;
                if (ok(index))
                {
                    ErrFlag = false;
                    return a[index];
                }
                else
                {
                    ErrFlag = true;
                    return 0;
                }
            }
            // Это аксессор set.
            set
            {
                int index;
                // Округлить до ближайшего целого.
                if ((idx - (int)idx) < 0.5) index = (int)idx;
                else index = (int)idx + 1;
                if (ok(index))
                {
                    a[index] = value;
                    ErrFlag = false;
                }
                else ErrFlag = true;
            }
        }
        // Возвратить логическое значение true, если
        // индекс находится в установленных границах.
        private bool ok(int index)
        {
            if (index >= 0 & index < Length) return true;
            return false;
        }
    }
    // Продемонстрировать применение отказоустойчивого массива.
    class FSDemo
    {
        static void Main()
        {
            FailSoftArray fs = new FailSoftArray(5);
            // Поместить ряд значений в массив fs.
            for (int i = 0; i < fs.Length; i++)
                fs[i] = i;
            // А теперь воспользоваться индексами
            // типа int и double для обращения к массиву.
            Console.WriteLine("fs[1] : " + fs[1]);
            Console.WriteLine("fs[2] : " + fs[2]);
            Console.WriteLine("fs[1.1]: " + fs[1.1]);
            Console.WriteLine("fs[1.6]: " + fs[1.6]);
        }
    }
}
