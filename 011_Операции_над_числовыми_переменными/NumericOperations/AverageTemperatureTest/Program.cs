using System;

namespace AverageTemperatureTest
{
    class Program
    {
        static void Main(string[] args)
        {
            float T_mo = 1, T_tu = 1, T_we = 1, T_th = 1, T_fr = 1, T_sa = 1, T_su = 1;
            int daysInWeek = 7;

            float T_sum = T_mo + T_tu + T_we + T_th + T_fr + T_sa + T_su; // == 7

            float T_avg = T_sum / daysInWeek;  // == 1

            Console.WriteLine(T_sum);
            Console.WriteLine(T_avg);

            // Delay
            Console.ReadKey();
        }
    }
}
