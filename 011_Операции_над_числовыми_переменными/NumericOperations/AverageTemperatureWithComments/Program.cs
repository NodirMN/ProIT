using System;

namespace AverageTemperatureWithComments
{
    class Program
    {
        static void Main(string[] args)
        {
            float T_avg = (/*T пн*/3f + /*T вт*/(-2f) + /*T ср*/(-5f) + 
                           /*T чт*/3f + /*T пт*/1f + /*T сб*/4f + 
                           /*T вс*/(-3f)) / /*T к-во дней в неделе*/7f;

            Console.WriteLine(T_avg);

            // Delay
            Console.ReadKey();
        }
    }
}
