using System;

namespace Conv
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.MaxValue;
            int b = checked((int)a);
            Console.WriteLine(b);

            ulong c = ulong.MaxValue;
            uint d = checked((uint)c);
            Console.WriteLine(d);

            double e = double.MaxValue;
            int f = checked((int)e);
            Console.WriteLine(f);

            // Delay.
            Console.ReadKey();
        }
    }
}
