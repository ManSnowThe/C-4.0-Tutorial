using System;
using System.Runtime.InteropServices;
class ExternMeth
{
    // Здесь объявляется внешний метод.
    [DllImport("ExtMeth.dll")]
    public extern static int AbsMax(int a, int b);
    static void Main()
    {
        // Использовать внешний метод.
        int max = AbsMax(-10, -20);
        Console.WriteLine(max);
    }
}
/*
Ниже приведен ис­ ходный код С из первого файла ExtMeth.с, где определяется метод AbsMax().
#include <stdlib.h>
int __declspec(dllexport) AbsMax(int a, int b)
{
    return abs(a) < abs(b) ? abs(b) : abs(a);
}*/