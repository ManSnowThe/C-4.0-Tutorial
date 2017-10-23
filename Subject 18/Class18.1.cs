﻿// Простой пример обобщенного класса.
using System;

// В приведенном ниже классе Gen параметр типа Т заменяется
// реальным типом данных при создании объекта типа Gen.
namespace ca2
{
    class Gen<T>
    {
        T ob; // объявить переменную типа T

        // Обратите внимание на то, что у этого конструктора имеется параметр типа Т.
        public Gen(T o)
        {
            ob = o;
        }
        // Возвратить переменную экземпляра ob, которая относится к типу T
        public T GetOb()
        {
            return ob;
        }
        
        // Показать тип Т
        public void ShowType()
        {
            Console.WriteLine("К типу T относится " + typeof(T));
        }
    }
    // Продемонстрировать применение обобщенного класса.
    class GenericsDemo
    {
        static void Main()
        {
            // Создать переменную ссылки на объект Gen типа int.
            Gen<int> iOb;

            // Создать объект типа Gen<int> и присвоить ссылку на него переменной iOb.
            iOb = new Gen<int>(102);

            // Показать тип данных, хранящихся в переменной iOb.
            iOb.ShowType();

            // Получить значение переменной iOb.
            int v = iOb.GetOb();
            Console.WriteLine("Значение: " + v);

            Console.WriteLine();

            // Создать объект типа Gen для строк.
            Gen<string> strOb = new Gen<string>("Обобщения повышают эффективность.");

            // Показать тип данных, хранящихся в переменной strOb
            strOb.ShowType();

            // Получить значение переменной strOb.
            string str = strOb.GetOb();
            Console.WriteLine("Значение: " + str);
        }
    }
}
