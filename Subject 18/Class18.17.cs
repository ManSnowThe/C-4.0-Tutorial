// Продемонстрировать применение обобщенных
// интерфейсов IComparable<T> и IEquatable<T>.
using System;

namespace ca2
{
    // Теперь в классе MyClass реализуются обобщенные
    // интерфейсы IComparable<T> и IEquatable<T>.
    class MyClass : IEquatable<MyClass>, IComparable<MyClass>
    {
        public int Val;
        public MyClass(int x)
        {
            Val = x;
        }
        // Реализовать обобщенный интерфейс IComparable<T>.
        public int CompareTo(MyClass other)
        {
            return Val - other.Val; // Now, no cast is needed.
        }
        // Реализовать обощенный интерфейс IEquatable<T>.
        public bool Equals(MyClass other)
        {
            return Val == other.Val;
        }

        // Переопределить метод Equals(Object).
        public override bool Equals(Object obj)
        {
            if (obj is MyClass)
                return Equals((MyClass)obj);
            return false;
        }

        // Переопределить метод GetHashCode().
        public override int GetHashCode()
        {
            return Val.GetHashCode();
        }
    }
    class CompareDemo
    {
        // Требуется обобщенный интерфейс IEquatable<T>.
        public static bool IsIn<T>(T what, T[] obs) where T : IEquatable<T>
        {
            foreach (T v in obs)
                if (v.Equals(what)) // Применяется метод Equals.
                    return true;
            return false;
        }
        // Требуется обобщенный интерфейс IComparable<T>. В данном методе
        // предполагается, что массив отсортирован. Он возвращает логическое
        // значение true, если значение параметра what оказывается среди элементов
        // массива, передаваемых параметру obs.
        public static bool InRange<T>(T what, T[] obs) where T : IComparable<T>
        {
            if (what.CompareTo(obs[0]) < 0 ||
                what.CompareTo(obs[obs.Length - 1]) > 0) return false;
            return true;
        }
        // Продемонстрировать операции сравнения.
        static void Main()
        {
            // Применить метод IsIn() к данным типа int.
            int[] nums = { 1, 2, 3, 4, 5 };

            if (IsIn(2, nums))
                Console.WriteLine("Найдено значение 2.");
            if (IsIn(99, nums))
                Console.WriteLine("Не подлежит выводу.");

            // Применить метод IsIn() к объектам класса MyClass.
            MyClass[] mcs = { new MyClass(1), new MyClass(2), new MyClass(3), new MyClass(4) };

            if (IsIn(new MyClass(3), mcs))
                Console.WriteLine("Найден объект MyClass(3).");

            if (IsIn(new MyClass(99), mcs))
                Console.WriteLine("He подлежит выводу.");

            // Применить метод InRange() к данным типа int.
            if (InRange(2, nums))
                Console.WriteLine("Значение 2 находится в границах массива nums.");
            if (InRange(1, nums))
                Console.WriteLine("Значение 1 находится в границах массива nums.");
            if (InRange(5, nums))
                Console.WriteLine("Значение 5 находится в границах массива nums.");
            if (!InRange(0, nums))
                Console.WriteLine("Значение 0 HE находится в границах массива nums.");
            if (!InRange(6, nums))
                Console.WriteLine("Значение 6 HE находится в границах массива nums.");

            // Применить метод InRange() к объектам класса MyClass.
            if (InRange(new MyClass(2), mcs))
                Console.WriteLine("Объект MyClass(2) находится в границах массива mcs.");
            if (InRange(new MyClass(1), mcs))
                Console.WriteLine("Объект MyClass(1) находится в границах массива mcs.");
            if (InRange(new MyClass(4), mcs))
                Console.WriteLine("Объект MyClass(4) находится в границах массива mcs.");
            if (!InRange(new MyClass(0), mcs))
                Console.WriteLine("Объект MyClass(0) HE находится в границах массива mcs.");
            if (!InRange(new MyClass(5), mcs))
                Console.WriteLine("Объект MyClass(5) HE находится в границах массива mcs.");
        }
    }
}
