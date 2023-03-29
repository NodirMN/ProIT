using System;

namespace DiscountCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Запросить у кассира, ввести количество плитки в метрах квадратных,
            //   цену плитки за квадратный метр.
            uint quontiti, price;
            {
                Console.Write("Количество плитки: ");
                quontiti = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Цена за 1 м.кв. плитки: ");
                price = Convert.ToUInt32(Console.ReadLine());
            }
            // 2.Посчитать общую стоимость плитки
            decimal cost = quontiti * price; // руб.
            // 3.Посчитать сумму скидки в 10 %
            decimal discount = 0;
            {
                const decimal MIN_QUANTITY_FOR_DISCOUNT = 100; // м.кв.
                bool discountAvailable = quontiti >= MIN_QUANTITY_FOR_DISCOUNT;

                if (discountAvailable)
                {
                    const decimal DISCOUNT_PERSENTAGE = 10; // %
                    discount = cost / 100 * DISCOUNT_PERSENTAGE;
                }
            }
            // 4.Посчитать сумму к оплате с учетом скидки
            decimal paymentAmount = cost - discount;
            // 5.Вывести на экран: общую стоимость, сумму скидки и сумму к оплате
            Console.WriteLine($"Общая стоимость плитки: {cost} руб.");
            Console.WriteLine($"Скидка                : {discount} руб.");
            Console.WriteLine($"Сумма к оплате        : {paymentAmount} руб.");

            // Delay
            Console.ReadKey();
        }
    }
}
