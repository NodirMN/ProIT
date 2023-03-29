using System;

namespace EndlessRecursion
{
    class Program
    {
        static void Procedure()
        {
            Procedure();
        }

        static void Main()
        {
            Procedure();
        }
    }
}
