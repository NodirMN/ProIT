using System;

namespace NegationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Условимся, что минимальная зарплата = 1000$
            int salary = 500, minimumWage = 1000;

            bool salaryNotLessMinimumWage = !(salary < minimumWage);
            Console.WriteLine($"Зарплата {salary} USD не меньше минимальной: {salaryNotLessMinimumWage}");

            bool salaryLessMinimumWage = salary < minimumWage;
            Console.WriteLine($"Зарплата {salary} USD меньше минимальной: {salaryLessMinimumWage}");

            bool salaryNotMoreMinimumWage = !(salary > minimumWage);
            Console.WriteLine($"Зарплата {salary} USD не больше минимальной: {salaryNotMoreMinimumWage}");

            bool salaryMoreMinimumWage = salary > minimumWage;
            Console.WriteLine($"Зарплата {salary} USD больше минимальной: {salaryMoreMinimumWage}");

            // Delay
            Console.ReadKey();
        }
    }
}
