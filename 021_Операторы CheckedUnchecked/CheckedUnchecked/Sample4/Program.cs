using System;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            uint minutesQuarter;
            {
                //1. Запросить у бухгалтера количество минут помесячно.
                Console.Write("Введите количество минут разговоров за январь : ");
                uint minutesJanuary = Convert.ToUInt32(Console.ReadLine());

                Console.Write("Введите количество минут разговоров за февраль: ");
                uint minutesFebruary = Convert.ToUInt32(Console.ReadLine());

                Console.Write("Введите количество минут разговоров за март   : ");
                uint minutesMarch = Convert.ToUInt32(Console.ReadLine());

                checked
                {
                    // 2. Посчитать количество минут разговора за квартал.
                    minutesQuarter = minutesJanuary + minutesFebruary + minutesMarch;
                }
            }

            decimal totalCost; // руб.
            {
                // 3. Посчитать общую стоимость всех разговоров за квартал.
                decimal price = 2; // руб.
                totalCost = minutesQuarter * price;
            }

            decimal tax; // руб.
            {
                // 4. Посчитать сумму налогов за квартал.
                decimal taxRate = 20; // %
                tax = totalCost / 100 * taxRate;
            }

            // 5. Вывести на экран: общее количество минут разговоров за квартал, 
            //                      общую стоимость всех минут и сумму налога.
            Console.WriteLine($"Всего                : {minutesQuarter} минут");
            Console.WriteLine($"Стоимость всех минут : {totalCost} рублей");
            Console.WriteLine($"Заплатить налог      : {tax} рублей");

            // Delay.
            Console.ReadKey();
        }
    }
}
