using System;

namespace DiscountCalculator
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

            decimal discount; // руб.
            {
                decimal discountPersentage; // %
                {
                    bool discount20PctAvailable, discount50PctAvailable;
                    {
                        const decimal MIN_TILE_QTY_FOR_DISCOUNT_20_PCT = 500,
                                      MIN_TILE_QTY_FOR_DISCOUNT_50_PCT = 1000; // м.кв.

                        discount20PctAvailable = tileQuontiti >= MIN_TILE_QTY_FOR_DISCOUNT_20_PCT &&
                                                 tileQuontiti < MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;

                        discount50PctAvailable = tileQuontiti >= MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;
                    }

                    if (discount20PctAvailable)
                    {
                        discountPersentage = 20; // %
                    }
                    else if (discount50PctAvailable)
                    {
                        discountPersentage = 50; // %
                    }
                    else
                    {
                        discountPersentage = 0; // %
                    }
                }

                discount = tileCost / 100 * discountPersentage;
            }

            decimal paymentAmount = tileCost - discount;

            {
                Console.WriteLine($"Общая стоимость плитки: {tileCost} руб.");
                Console.WriteLine($"Скидка                : {discount} руб.");
                Console.WriteLine($"Сумма к оплате        : {paymentAmount} руб.");
            }

            // Delay
            Console.ReadKey();
        }
    }
}
