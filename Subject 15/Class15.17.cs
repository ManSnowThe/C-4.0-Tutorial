// Создать специальные средства для управления списками
// вызова обработчиков событий.using System;

namespace ca2
{
    // Объявить тип делегата для события.
    delegate void MyEventHandler();
    // Объявить класс, содержащий событие.
    class MyEvent
    {
        MyEventHandler[] evnt = new MyEventHandler[3];

        public event MyEventHandler SomeEvent
        {
            // Добавить событие в список.
            add
            {
                int i;
                for(i=0; i<3; i++)
                    if (evnt[i] == null)
                    {
                        evnt[i] = value;
                        break;
                    }
                if (i == 3) Console.WriteLine("Список событий заполнен");
            }

            // Удалить события из списка.
            remove
            {
                int i;

                for(i=0; i<3; i++)
                    if (evnt[i] == value)
                    {
                        evnt[i] = null;
                        break;
                    }
                if (i == 3) Console.WriteLine("Обработчик событий не найден.");
            }
        }
        // Этот метод вызывается для запуска событий.
        public void OnSomeEvent()
        {
            for (int i = 0; i < 3; i++)
                if (evnt[i] != null)
                    evnt[i]();
        }
    }
    // Создать ряд классов, использующих делегат MyEventHandler.
    class W
    {
        public void Whandler()
        {
            Console.WriteLine("Событие получено объектом W");
        }
    }
    class X
    {
        public void Xhandler()
        {
            Console.WriteLine("Событие получено объектом X");
        }
    }
    class Y
    {
        public void Yhandler()
        {
            Console.WriteLine("Событие получено объектом Y");
        }
    }
    class Z
    {
        public void Zhandler()
        {
            Console.WriteLine("Событие получено объектом Z");
        }
    }

    class EventDemo5
    {
        static void Main()
        {
            MyEvent evt = new MyEvent();
            W wOb = new W();
            X xOb = new X();
            Y yOb = new Y();
            Z zOb = new Z();

            // Добавить обработчики в цепочку событий.
            Console.WriteLine("Добавление событий. ");
            evt.SomeEvent += wOb.Whandler;
            evt.SomeEvent += xOb.Xhandler;
            evt.SomeEvent += yOb.Yhandler;

            // Сохранить нельзя - список заполнен.
            evt.SomeEvent += zOb.Zhandler;
            Console.WriteLine();

            // Запустить события.
            evt.OnSomeEvent();
            Console.WriteLine();

            // Удалить обработчик.
            Console.WriteLine("Удаление обработчика xOb.Xhandler.");
            evt.SomeEvent -= xOb.Xhandler;
            evt.OnSomeEvent();

            Console.WriteLine();

            // Попробовать удалить обработчик еще раз.
            Console.WriteLine("Попытка удалить обработчик xOb.Xhandler еще раз.");
            evt.SomeEvent -= xOb.Xhandler;
            evt.OnSomeEvent();

            Console.WriteLine();

            // А теперь добавить обработчик Zhandler.
            evt.SomeEvent += zOb.Zhandler;
            evt.OnSomeEvent();
        }
    }
}
