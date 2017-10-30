// Продемонстрировать применение буфера фиксированного размера.
using System;

namespace ca2
{
    // Создать буфер фиксированного размера.
    unsafe struct FixedBankRecord
    {
        public fixed byte Name[80];
        public double Balance;
        public long ID;
    }
    class FixedSizeBuffer
    {
        // Пометить метод Main() как небезопасный.
        unsafe static void Main()
        {
            Console.WriteLine("Размер структуры FixedBankRecord: " + sizeof(FixedBankRecord));
        }
    }
}
