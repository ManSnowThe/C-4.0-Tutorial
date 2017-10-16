// Использовать модификатор ref для передачи значения обычного типа по ссылке.
using System;

namespace ca2
{
    class RefTest
    {
        // Этот метод изменяет свой аргумент. Обратите
        // внимание на применение модификатора ref.
        public void Sqr(ref int i)
        {
            i = i * i;
        }
    }

    class RefDemo
    {
        static void Main()
        {
            RefTest ob = new RefTest();
            int a = 10;

            Console.WriteLine("а до вызова: " + a);

            ob.Sqr(ref a);  // обратите внимание на применение модификатора ref

            Console.WriteLine("a после вызова: " + a);


        }
    }
}
