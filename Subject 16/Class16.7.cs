// Использовать псевдоним глобального пространства имен.using System;
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
// Объявить еще один класс CountDown, принадлежащий
// глобальному пространству имен.class CountDown
{
    int val;
    public CountDown(int n)
    {
        val = n;
    }
    // ...
}

class GlobalAliasQualifierDemo
{
    static void Main()
    {
        // Здесь описатель :: предписывает компилятору использовать
        // класс CountDown из пространства имен Counter.
        Ctr::CountDown cd1 = new Ctr::CountDown(10);

        // Далее создать объект класса CountDown из
        // глобального пространства имен.
        global::CountDown cd2 = new global::CountDown(10);

        // ...
    }
}
