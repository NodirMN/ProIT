using System;

namespace AverageTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            float T_mo = 3, T_tu = -2, T_we = -5, T_th = 3, T_fr = 1, T_sa = 4, T_su = -3;
            int daysInWeek = 7;

            float T_sum = T_mo + T_tu + T_we - T_th + T_fr + T_sa + T_su;

            float T_avg = T_sum / daysInWeek;

            Console.WriteLine(T_avg);

            // Delay
            Console.ReadKey();
        }
    }
}
