using System;

namespace Suffixes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;
            sbyte b = -128;
            ushort c = 65_535;
            short d = -32_768;

            uint e = 4_294_967_295U;
            int f = -2_147_483_648;

            ulong g = 18_446_744_073_709_551_615UL;
            long h = -9_223_372_036_854_775_808L;

            float i = -1.12345F;
            double j = -1.12345D;
            decimal k = -1.12345M;


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);

            // Delay
            Console.ReadKey();
        }
    }
}
