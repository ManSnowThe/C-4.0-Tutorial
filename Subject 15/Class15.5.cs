// Продемонстрировать ковариантность и контравариантность.
using System;

namespace ca2
{
    class X
    {
        public int Val;
    }
    // Класс Y, производный от класса X.
    class Y : X
    {

    }
    // Этот делегат возвращает объект класса X и
    // принимает объект класса Y в качестве аргумента.
    delegate X ChangeIt(Y obj);
    class CoContraVariance
    {
        // Этот метод возвращает объект класса X и
        // имеет объект класса X в качестве параметра.
        static X IncrA(X obj)
        {
            X temp = new X();
            temp.Val = obj.Val + 1;
            return temp;
        }
        // Этот метод возвращает объект класса Y и
        // имеет объект класса Y в качестве параметра.
        static Y IncrB(Y obj)
        {
            Y temp = new Y();
            temp.Val = obj.Val + 1;
            return temp;
        }
        static void Main()
        {
            Y Yob = new Y();
            // В данном случае параметром метода IncrA является объект класса X,
            // а параметром делегата ChangeIt — объект класса Y. Но благодаря
            // контравариантности следующая строка кода вполне допустима.
            ChangeIt change = IncrA;
            X Xob = change(Yob);

            Console.WriteLine("Xob: " + Xob.Val);
            // В этом случае возвращаемым типом метода IncrB служит объект класса Y,
            // а возвращаемым типом делегата ChangeIt — объект класса X. Но благодаря
            // ковариантности следующая строка кода оказывается вполне допустимой.
            change = IncrB;

            Yob = (Y)change(Yob);

            Console.WriteLine("Yob: " + Yob.Val);
        }
    }
}
