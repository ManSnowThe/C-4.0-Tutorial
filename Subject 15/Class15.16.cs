/* Уведомления о событии получает класс, когда статический метод
используется в качестве обработчика событий. */using System;

namespace ca2
{
    // Объявить тип делегата для события.
    delegate void MyEventHandler();
    // Объявить класс, содержащий событие.
    class MyEvent
    {
        public event MyEventHandler SomeEvent;

        // Этот метод вызывается для запуска события.
        public void OnSomeEvent()
        {
            if (SomeEvent != null)
                SomeEvent();
        }
    }
    class X
    {
        /* Этот статический метод предназначен в качестве
         * обработчика событий. */
         public static void Xhandler()
        {
            Console.WriteLine("Событие получено классом.");
        }
    }
    class MyEventDemo4
    {
        static void Main()
        {
            MyEvent evt = new MyEvent();

            evt.SomeEvent += X.Xhandler;

            // Запустить событие.
            evt.OnSomeEvent();
        }
    }
}
