// Использовать встроенный делегат EventHandler.
using System;

namespace ca2
{
    // Объявить класс, содержащий событие
    class MyEvent
    {
        public event EventHandler SomeEvent; // использовать делегат EventHandler
        
        // Этот метод вызывается для запуска события.
         public void OnSomeEvent()
        {
            if (SomeEvent != null)
                SomeEvent(this, EventArgs.Empty);
        }
    }

    class EventDemo7
    {
        static void Handler(object source, EventArgs arg)
        {
            Console.WriteLine("Произошло событие.");
            Console.WriteLine("Источник: " + source);
        }

        static void Main()
        {
            MyEvent evt = new MyEvent();
            evt.SomeEvent += Handler;

            // Запустить событие.
            evt.OnSomeEvent();
        }
    }
}
