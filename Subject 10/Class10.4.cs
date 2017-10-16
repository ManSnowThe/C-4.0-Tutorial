// Двумерный отказоустойчивый массив.
using System;

namespace ca2
{
    class FailSoftArray2D
    {
        int[,] a; // ссылка на базовый двумерный массив
        int rows, cols; // размеры массива
        public int Length; // открытая переменная длины массива
        public bool ErrFlag; // обозначает результат последней операции
                             // Построить массив заданных размеров.
        public FailSoftArray2D(int r, int c)
        {
            rows = r;
            cols = c;
            a = new int[rows, cols];
            Length = rows * cols;
        }        // Это индексатор для класса FailSoftArray2D.
        public int this[int index1, int index2]{
            // Это аксессор get
            get{
                if(ok(index1, index2))
                {
                    ErrFlag = false;
                    return a[index1, index2];
                }
                else
                {
                    ErrFlag = true;
                    return 0;
                }
            }
            // Это аксессор set
            set
            {
                if (ok(index1, index2))
                {
                    a[index1, index2] = value;
                        ErrFlag = false;
                }
                else ErrFlag = true;
            }
        }
        // Возвратить логическое значение true, если
        // индексы находятся в установленных пределах.
        private bool ok(int index1, int index2)
        {
            if (index1 >= 0 & index1 < rows & index2 >= 0 & index2 < cols)
                return true;

            return false;
        }
    }
    // Продемонстрировать применение двумерного индексатора.
    class TwoDIndexerDemo
    {
        static void Main()
        {
            FailSoftArray2D fs = new FailSoftArray2D(3, 5);
            int x;

            // Выявить скрытые сбои.
            Console.WriteLine("Скрытый сбой.");
            for(int i=0; i<6; i++)          
                fs[i, i] = i * 10;
            
            for(int i=0; i<6; i++)
            {
                x = fs[i, i];
                if (x != -1) Console.Write(x + " ");
            }
            Console.WriteLine();
            
            // А теперь показать сбои.
            Console.WriteLine("\nСбой с уведомлением об ошибках.");
            for (int i = 0; i < 6; i++)
            {
                fs[i, i] = i * 10;
                if (fs.ErrFlag)
                    Console.WriteLine("fs[" + i + ", " + i + "] вне границ");
            }

            for (int i = 0; i < 6; i++)
            {
                x = fs[i, i];
                if (!fs.ErrFlag) Console.Write(x + " ");
                else
                    Console.WriteLine("fs[" + i + ", " + i + "] вне границ");
            }
        }
    }
}
