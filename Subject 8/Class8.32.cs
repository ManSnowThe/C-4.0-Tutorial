// Применить статический конструктор.
using System;

namespace ca2
{
    class Cons
    {
        public static int alpha;
        public int beta;

        static Cons()
        {
            alpha = 99;
            Console.WriteLine("В статическом конструкторе.");
        }
        public Cons()
        {
            beta = 100;
            Console.WriteLine("В конструкторе экзмепляра.");
        }

        class ConsDemo
        {
            static void Main()
            {
                Cons ob = new ca2.Cons();
                Console.WriteLine("Cons.alpha: " + Cons.alpha);
                Console.WriteLine("ob.beta: " + ob.beta);
            }
        }
    }
    
}
