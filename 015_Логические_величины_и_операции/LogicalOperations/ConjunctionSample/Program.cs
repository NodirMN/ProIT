using System;

namespace ConjunctionSample
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

            int minSalary = 1500, minAge = 21, maxAge = 55;

            bool bankLoanAllowed = clientSalary >= minSalary & clientAge >= minAge & clientAge <= maxAge;
            Console.WriteLine($"Кредитование доступно: {bankLoanAllowed}");

            // Delay
            Console.ReadKey();
        }
    }
}
