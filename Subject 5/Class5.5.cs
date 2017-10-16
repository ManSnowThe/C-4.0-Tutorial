using System;


namespace ca2
{
    class Class5
    {
        static void Main()
        {
            int i, j;
            bool done = false;
            for(i=0, j=100; !done; i++, j--)
            {
                if (i * i >= j) done = true;
                Console.WriteLine("i и j: {0} {1}", i, j);
            }
        }
    }
}
