using System;

namespace DisjunctionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Возраст клиента: ");
            int clientAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Зарплата клиента: ");
            int clientSalary = Convert.ToInt32(Console.ReadLine());

            Console.Write("Наличие поручителя (да/нет): ");
            bool hasGuarantor = Console.ReadLine() == "да";

            Console.Write("Наличие залогового обеспечения (да/нет): ");
            bool hasCollateralSecurity = Console.ReadLine().Contains("да");

            // Требование: Возраст от 21 до 55 лет "И" Зарплата не меннее 1500 доллларов
            // "ИЛИ" если есть поручитель "ИЛИ" залоговое обеспечение, то кредит можно выдать

            int minSalary = 1500, minAge = 21, maxAge = 55;

            bool bankLoanAllowed = clientSalary >= minSalary & clientAge >= minAge & clientAge <= maxAge |
                                   hasGuarantor | hasCollateralSecurity;

            Console.WriteLine($"Кредитование доступно: {bankLoanAllowed}");

            // Delay
            Console.ReadKey();
        }
    }
}
