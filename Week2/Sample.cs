using System;

namespace Week2
{
    class Sample
    {
        public static void fun1()
        {
            Console.WriteLine("Bix1 method");
        }
        public void fun2()
        {
            fun1();
            Console.WriteLine("Bix2 method");
        }
        public void fun2(int i)
        {
            Console.WriteLine(i);
            fun2();
        }

    }
}
