/* Уведомления о событиях получают отдельные объекты, когда метод экземпляра
используется в качестве обработчика событий. */
using System;

namespace ca2
{
    // Объявить тип делегата для события.
    delegate void MyEventHandler();
    // Объявить класс содержащий событие.
    class MyEvent
    {
        public event MyEventHandler SomeEvent;
                // Этот метод вызывается для запуска события.        public void OnSomeEvent()
        {
            if (SomeEvent != null)
                SomeEvent();
        }
    }
    class X
    {
        int id;
        public X(int x)
        {
            id = x;
        }
        // Этот метод экземпляра предназначен в качестве обработчика событий.
        public void Xhandler()
        {
            Console.WriteLine("Событие получено объектом " + id);
        }
    }
    class EventDemo3
    {
        static void Main()
        {
            MyEvent evt = new MyEvent();

            X ob1 = new ca2.X(1);
            X ob2 = new ca2.X(2);
            X ob3 = new ca2.X(3);

            evt.SomeEvent += ob1.Xhandler;
            evt.SomeEvent += ob2.Xhandler;
            evt.SomeEvent += ob3.Xhandler;

            //Запустить событие.
            evt.OnSomeEvent();
        }
    }
}
