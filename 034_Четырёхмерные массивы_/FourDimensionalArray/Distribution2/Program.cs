using System;

namespace Distribution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "январь", "февраль", "март" };
            string[] tiles = { "Агат", "Оникс", "Малахит" };
            string[] distributors = { "Мир керамики", "Дом плитки" };
            string[] countries = { "Италия", "Испания" };
            decimal[,,,] array = new decimal[countries.Length, distributors.Length, tiles.Length, months.Length];

            for (int w = 0; w < array.GetLength(0); w++)
                for (int z = 0; z < array.GetLength(1); z++)
                    for (int y = 0; y < array.GetLength(2); y++)
                        for (int x = 0; x < array.GetLength(3); x++)
                        {
                            Console.Write($"{distributors[z]} продал плитки {tiles[y]} за {months[x]} в {countries[w]}: ");
                            array[w, z, y, x] = Convert.ToDecimal(Console.ReadLine());
                        }

            while (true)
            {
                Console.Write("Введите название дистрибьютора: ");
                string distributorName = Console.ReadLine();
                Console.Write("Введите название вида плитки: ");
                string tileName = Console.ReadLine();
                int distributorIndex = Array.IndexOf(distributors, distributorName);
                int tailIndex = Array.IndexOf(tiles, tileName);
                decimal numberOfTiles = 0;

                for (int w = 0; w < array.GetLength(0); w++)
                    for (int x = 0; x < array.GetLength(3); x++)
                        numberOfTiles += array[w, distributorIndex, tailIndex, x];

                Console.WriteLine($"{distributorName} продал {numberOfTiles} шт. плитки {tileName} за квартал.");
            }

            // Delay
            Console.ReadKey();
        }
    }
}
