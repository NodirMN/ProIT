using System;

namespace ConditionalConjunctionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст клиента: ");
            int clientAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите зарплату клиента: ");
            int clientSalary = Convert.ToInt32(Console.ReadLine());

            // Требования для получение банковского заёма:
            // 1. Возраст от 21 до 55 лет
            // 2. Зарплата не меннее 1500 доллларов

            const int MIN_SALARY = 1500, MIN_AGE = 21, MAX_AGE = 55;

            bool bankLoanAllowed = MIN_SALARY <= clientSalary && MIN_AGE <= clientAge && MAX_AGE >= clientAge;

            Console.WriteLine($"Кредитование доступно: {bankLoanAllowed}");

            // Delay
            Console.ReadKey();
        }
    }
}
