// Добавить свойство Length в класс FailSoftArray.
// Превратить переменную ErrFlag в свойство.
using System;

namespace ca2
{
    class FailSoftArray
    {
        int[] a; // ссылка на базовый массив
        int len;  // длина массива — служит основанием для свойства Length

        bool ErrFlag; // обозначает результат последней операции

        // Построить массив заданного размера.        public FailSoftArray(int size)
        {
            a = new int[size];
            len = size;
        }
        // Свойство Length только для чтения.
        public int Length
        {
            get
            {
                return len;
            }
        }
        
        // Свойство Error только для чтения.
        public bool Error
        {
            get
            {
                return ErrFlag;
            }
        }
        // Это индексатор для класса FailSoftArray.
        public int this[int index]
        {
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
            set
            {
                if (ok(index))
                {
                    a[index] = value;
                    ErrFlag = false;
                }
                else
                {
                    ErrFlag = true;
                }
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
    // Продемонстрировать применение усовершенствованного
    // отказоустойчивого массива.
    class ImprovedFSDemo
    {
        static void Main()
        {
            FailSoftArray fs = new FailSoftArray(5);
            int x;

            // Разрешить чтение свойства Length.
            for (int i = 0; i < fs.Length; i++)
                fs[i] = i*10;

            for(int i=0; i<fs.Length; i++)
            {
                x = fs[i];
                Console.Write(x + " ");
            }
            Console.WriteLine();
            // fs.Length = 10; // Ошибка, запись запрещена!

            // Использовать свойство Error.
            for (int i = 0; i < fs.Length + 1; i++)
            {
                fs[i] = i * 10;
                if (fs.Error)
                    Console.WriteLine("Ошибка в индексе " + i);
            }
        }
    }
}
