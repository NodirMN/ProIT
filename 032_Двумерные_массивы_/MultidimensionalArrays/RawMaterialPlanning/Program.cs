using System;

namespace RawMaterialPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            // планируемыеЗатратыНаПлитку1, планируемыеЗатратыНаПлитку2, планируемыеЗатратыНаПлитку3
            decimal plannedCostOfTiles1, plannedCostOfTiles2, plannedCostOfTiles3;
            {
                // песокДляПлитки1 = 5 кг, песокДляПлитки2 = 3 кг, песокДляПлитки3 = 2 кг
                decimal sandForTail1 = 5, sandForTail2 = 3, sandForTail3 = 2; // кг.
                // глинаДляПлитки1 = 4 кг, глинаДляПлитки1 = 7 кг, глинаДляПлитки1 = 6 кг
                decimal clayForTail1 = 4, clayForTail2 = 7, clayForTail3 = 6; // кг.
                // ценаПеска = 70 руб.кг, ценаГлины = 50 руб.кг
                decimal sandPrice = 70, clayPrice = 50; // руб.кг
                // планируемыйОбъёмПлитки1 = 80 шт, планируемыйОбъёмПлитки1 = 140 шт, планируемыйОбъёмПлитки1 = 60 шт
                decimal plannedVolumeOfTiles1 = 80, plannedVolumeOfTiles2 = 140, plannedVolumeOfTiles3 = 60; // шт.

                // Рассчитать планируемыеЗатратыНаПлитку: 1-2-3
                plannedCostOfTiles1 = (sandForTail1 * sandPrice + clayForTail1 * clayPrice) * plannedVolumeOfTiles1;
                plannedCostOfTiles2 = (sandForTail2 * sandPrice + clayForTail2 * clayPrice) * plannedVolumeOfTiles2;
                plannedCostOfTiles3 = (sandForTail3 * sandPrice + clayForTail3 * clayPrice) * plannedVolumeOfTiles3;
            }

            // общаяСтоимость = планируемыеЗатратыНаПлитку1 + планируемыеЗатратыНаПлитку2 + планируемыеЗатратыНаПлитку3
            decimal totalCost = plannedCostOfTiles1 + plannedCostOfTiles2 + plannedCostOfTiles3;
            Console.WriteLine($"Общая стоимость сырья = {totalCost}");

            // Delay
            Console.ReadKey();
        }
    }
}
