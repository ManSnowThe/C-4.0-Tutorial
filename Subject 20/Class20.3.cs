//Доступ к членам структуры с помощью указателяusing System;

namespace ca2
{
    struct MyStruct
    {
        public int a;
        public int b;
        public int Sum()
        {
            return a + b;
        }
    }
    class StructDemo
    {
        unsafe static void Main()
        {
            MyStruct o = new MyStruct();
            MyStruct* p;

            p = &o;
            p->a = 10; // использовать оператор ->
            p->b = 20; // использовать оператор ->

            Console.WriteLine("Сумма равна " + p->Sum());
        }
    }
}
