using System;

namespace ComplexityAndImaginaryActions
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tileQuontiti, tilePrice;
            {
                Console.Write("Количество плитки     : ");
                string stringQuontiti = Console.ReadLine();
                tileQuontiti = Convert.ToDecimal(stringQuontiti);

                Console.Write("Цена за 1 м.кв. плитки: ");
                string stringPrice = Console.ReadLine();
                tilePrice = Convert.ToDecimal(stringPrice);
            }

            decimal tileCost = tileQuontiti * tilePrice; // руб.

            decimal discountPersentage; // руб.
            {
                const decimal MIN_TILE_QTY_FOR_DISCOUNT_20_PCT = 500; // м.кв.
                bool discount20PctAvailable = tileQuontiti >= MIN_TILE_QTY_FOR_DISCOUNT_20_PCT;

                if (discount20PctAvailable)
                {
                    discountPersentage = 20; // %
                }
                else
                {
                    discountPersentage = 10; // %
                }
            }

            decimal discount = tileCost / 100 * discountPersentage;

            decimal paymentAmount = tileCost - discount;

            Console.WriteLine($"Общая стоимость плитки: {tileCost} руб.");
            Console.WriteLine($"Скидка                : {discount} руб.");
            Console.WriteLine($"Сумма к оплате        : {paymentAmount} руб.");

            // Delay
            Console.ReadKey();
        }
    }
}
