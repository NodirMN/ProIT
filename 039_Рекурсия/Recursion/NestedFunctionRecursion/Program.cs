using System;

namespace NestedFunctionRecursion
{
    class Program
    {
        static void ProcedureA()
        {
            Console.WriteLine("A");

            void ProcedureB()
            {
                Console.WriteLine("B");

                void ProcedureC()
                {
                    Console.WriteLine("C");

                    ProcedureA();
                }

                ProcedureC();
            }

            ProcedureB();
        }

        static void Main()
        {
            ProcedureA();
        }
    }
}
