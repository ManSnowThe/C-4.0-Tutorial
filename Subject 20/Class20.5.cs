/* Указание имени массива без индекса приводит к
формированию указателя на начало массива. */
using System;

namespace ca2
{
    class PtrArray
    {
        unsafe static void Main()
        {
            int[] nums = new int[10];

            fixed (int* p = &nums[0], p2 = nums)
                if (p == p2)
                    Console.WriteLine("Указатели p и p2 содержат один и тот же адрес."); 
        }
    }
}
