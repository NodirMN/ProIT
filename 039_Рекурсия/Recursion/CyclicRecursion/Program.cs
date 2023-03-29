using System;

namespace CyclicRecursion
{
    class Program
    {
        static void ProcedureA()
        {
            Console.WriteLine("A");
            ProcedureB();
        }
        static void ProcedureB()
        {
            Console.WriteLine("B");
            ProcedureC();
        }
        static void ProcedureC()
        {
            Console.WriteLine("C");
            ProcedureA();
        }

        static void Main()
        {
            ProcedureA();
        }
    }
}
