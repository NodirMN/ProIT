using System;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            int roomTotalCost;
            {
                int roomArea;
                {
                    const int ROOM_LENGTH = 5, ROOM_WIDTH = 4;
                    roomArea = ROOM_LENGTH * ROOM_WIDTH;
                }

                int parquetPriceWithLaying;
                {
                    const int PARQUET_PRICE = 5000, LAYING_PARQUET_PRICE = 600;
                    parquetPriceWithLaying = PARQUET_PRICE + LAYING_PARQUET_PRICE;
                }

                roomTotalCost = roomArea * parquetPriceWithLaying;
            }

            int kitchenTotalCost;
            {
                const int KITCHEN_LENGTH = 4, KITCHEN_WIDTH = 3, KITCHEN_AREA = KITCHEN_LENGTH * KITCHEN_WIDTH;
                const int TILE_PRICE = 4000, TILE_COST = KITCHEN_AREA * TILE_PRICE;
                const int LAYING_TILES_PRICE = 700, LAYING_TILES_COST = KITCHEN_AREA * LAYING_TILES_PRICE;
                kitchenTotalCost = TILE_COST + LAYING_TILES_COST;
            }

            int totalCost = roomTotalCost + kitchenTotalCost;
            Console.WriteLine(totalCost);

            // Delay.
            Console.ReadKey();
        }
    }
}
