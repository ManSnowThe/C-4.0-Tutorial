using System;
namespace ca2
{
    class cletter
    {
        
        static void Main()
        {
            decimal price;
            decimal discount;
            decimal discounted_price;

            price = 19.95m;
            discount = 0.15m;

            discounted_price = price - (price * discount);
            Console.WriteLine("Цена со скидкой {0:C}", discounted_price);
        }
    }
}