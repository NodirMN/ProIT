using System;

namespace AverageTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            float T_avg = (3f + (-2f) + (-5f) + 3f + 1f + 4f + (-3f)) / 7f;

            Console.WriteLine(T_avg);

            // Delay
            Console.ReadKey();
        }
    }
}
