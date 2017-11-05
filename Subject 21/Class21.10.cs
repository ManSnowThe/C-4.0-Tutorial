// Продемонстрировать применение делегата Action.
using System;

namespace ca2
{
    class MyClass
    {
        public int i;

        public MyClass(int x)
        {
            i = x;
        }
    }
    class ActionDemo
    {
        // Метод делегата Action, отображающий значение, которое ему передается.
        static void Show(MyClass o)
        {
            Console.Write(o.i + " ");
        }
        // Еще один метод делегата Action, делающий
        // отрицательным значение, которое ему передается.
        static void Neg(MyClass o)
        {
            o.i = -o.i;
        }
        static void Main()
        {
            MyClass[] nums = new MyClass[5];

            nums[0] = new MyClass(5);
            nums[1] = new MyClass(2);
            nums[2] = new MyClass(3);
            nums[3] = new MyClass(4);
            nums[4] = new MyClass(1);

            Console.Write("Содержимое массива nums: ");

            // Выполнить действие для отображения значений.
            Array.ForEach(nums, ActionDemo.Show);

            Console.WriteLine();

            // Выполнить действие для отрицания значений.
            Array.ForEach(nums, ActionDemo.Neg);

            Console.Write("Содержимое массива nums после отрицания: ");
            
            // Выполнить действие для повторного отображения значений.
            Array.ForEach(nums, ActionDemo.Show);

            Console.WriteLine();
        }
    }
}
