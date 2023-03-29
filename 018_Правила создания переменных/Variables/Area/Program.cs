using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int roomLength = 6, roomWidth = 5, roomArea = roomLength * roomWidth; // метры
            Console.WriteLine($"Room area = {roomArea}");

            int kitchenLength = 4, kitchenWidth = 3, kitchenArea = kitchenLength * kitchenWidth; // метры
            Console.WriteLine($"Kitchen area = {kitchenArea}");

            #region Плохой вариант

            //int length = 6, width = 5, area = length * width;
            //Console.WriteLine($"Room area = {area}");

            //length = 4;
            //width = 3;
            //area = length * width;
            //Console.WriteLine($"Kitchen area = {area}"); 

            #endregion

            // Delay
            Console.ReadKey();
        }
    }
}
