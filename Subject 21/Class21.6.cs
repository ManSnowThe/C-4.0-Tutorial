// Отсортировать массив объектов и осуществить в нем поиск.
using System;

namespace ca2
{
    class MyClass : IComparable<MyClass>
    {
        public int i;

        public MyClass(int x)
        {
            i = x;
        }
        // Реализовать интерфейс IComparable<MyClass>.
        public int CompareTo(MyClass v)
        {
            return i - v.i;
        }
        public bool Equals(MyClass v)
        {
            return i == v.i;
        }
    }
    class SortDemo
    {
        static void Main()
        {
            MyClass[] nums = new MyClass[5];

            nums[0] = new MyClass(5);
            nums[1] = new MyClass(2);
            nums[2] = new MyClass(3);
            nums[3] = new MyClass(4);
            nums[4] = new MyClass(1);

            // Отобразить исходный порядок следования.
            Console.Write("Исходный порядок следования: ");
            foreach (MyClass o in nums)
                Console.Write(o.i + " ");
            Console.WriteLine();

            // Отсортировать массив.
            Array.Sort(nums);
            // Отобразить порядок следования после сортировки.
            Console.Write("Порядок следования после сортировки: ");
            foreach (MyClass o in nums)
                Console.Write(o.i + " ");
            Console.WriteLine();

            // Найти объект MyClass(2).
            MyClass x = new MyClass(2);
            int idx = Array.BinarySearch(nums, x);

            Console.WriteLine("Индекс элемента массива с объектом MyClass(2): " + idx);
        }
    }
}
