// Продемонстрировать необходимость описателя ::using System;
using Counter;
using AnotherCounter;

// Присвоить классу Counter псевдоним Ctr.
using Ctr = Counter;

// Объявить пространство имен для счетчиков.
namespace Counter
{
    class CountDown
    {
        int val;
        public CountDown(int n)
        {
            val = n;
        }
        // ...
    }
}
// Объявить еще одно пространство имен для счетчиков.
namespace AnotherCounter
{
    // Объявить еще один класс CountDown, принадлежащий
    // пространству имен AnotherCounter.
    class CountDown
    {
        int val;
        public CountDown(int n)
        {
            val = n;
        }
        // ...
    }
}
class AliasQualifierDemo
{
    static void Main()
    {
        int i;

        // Здесь оператор :: разрешает конфликт, предписывая компилятору
        // использовать класс CountDown из пространства имен Counter.
        Ctr::CountDown cd1 = new Ctr::CountDown(10);
        
        // ...
    }
}

