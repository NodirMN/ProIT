using System;

namespace KeywordRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable = 1;

            ref int address = ref variable;

            Console.WriteLine($"variable = {variable}, address = {address}");

            address = 2;

            Console.WriteLine($"variable = {variable}, address = {address}");

            Console.WriteLine($"variable == address = {variable == address}");

            // ------------------------------------------------------------------------------------

            int a = 0, b = 0;

            ref int c = ref a, d = ref b;

            (true ? ref c : ref d) = 3;

            Console.WriteLine($"a = {a}, b = {b}, c = {c}, d = {d}");

            // ------------------------------------------------------------------------------------

            (true ? ref a : ref b) = 4;

            Console.WriteLine($"a = {a}, b = {b}");

            // ------------------------------------------------------------------------------------

            byte x = 3;
            ref byte y = ref x, z = ref y;
            z = 11;
            z += 1;
            Console.WriteLine($"x = {x}, y = {y}, z = {z}");

            var v = 7;
            ref var w = ref v;

            dynamic m = 5;
            ref dynamic n = ref m;

            string s = "Hello";
            ref string t = ref s;

            bool p = false;
            ref bool q = ref p;

            /*const*/ double PI = 3.14;
            ref readonly double r = ref PI;
            // r = 2.3; // Error!


            // Delay
            Console.ReadKey();
        }
    }
}
