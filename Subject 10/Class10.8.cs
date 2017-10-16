// Применить модификатор доступа в аксессоре.
using System;

namespace ca2
{
    class PropAccess
    {
        int prop; // поле, управляемое свойством МуРrор
        public PropAccess()
        {
            prop = 0;
        }
        /* Это свойство обеспечивает доступ к закрытой переменной экземпляра prop.
         * Оно разрешает получать значение переменной prop из любого кода,
         * но устанавливать его — только членам своего класса. */
         public int MyProp
        {
            get
            {
                return prop;
            }
            private set
            {
                prop = value;
            }
        }
        // Этот член класса инкрементирует значение свойства МуРrор.
        public void IncrProp()
        {
            MyProp++; // Допускается в том же самом классе.        }
        
        // Продемонстрировать применение модификатора доступа в аксессоре свойства.
        class PropAccesDemo
        {
            static void Main()
            {
                PropAccess ob = new PropAccess();
                Console.WriteLine("Первоначальное значение ob.МуРrор: " + ob.MyProp);

                // ob.МуРrор = 100; // недоступно для установки

                ob.IncrProp();
                Console.WriteLine("Значение ob.МуРrор после инкрементирования: " + ob.MyProp);

            }
        }
    }
}
