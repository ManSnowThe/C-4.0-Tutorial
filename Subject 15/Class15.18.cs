// Использовать лямбда-выражение в качестве обработчика событий.
using System;

namespace ca2
{
    // Объявить тип делегата для события.
    delegate void MyEventHandler(int n);
    // Объявить класс, содержащий событие.
    class MyEvent
    {
        public event MyEventHandler SomeEvent;
        public void OnSomeEvent(int n)
        {
            if (SomeEvent != null)
                SomeEvent(n);
        }
    }
    class LambdaEventDemo
    {
        static void Main()
        {
            MyEvent evt = new MyEvent();

            // Использовать лямбда-выражение в качестве обработчика событий.
            evt.SomeEvent += (n) => Console.WriteLine("Событие получено. Значение равно " + n);
            
            /* Использовать анонимный метод в качестве обработчика событий.
            // evt.SomeEvent += delegate(int n) {
            // Console.WriteLine("Событие получено. Значение равно " + n);
            // };            */

            // Запустить событие
            evt.OnSomeEvent(1);
            evt.OnSomeEvent(2);
        }
    }
}
