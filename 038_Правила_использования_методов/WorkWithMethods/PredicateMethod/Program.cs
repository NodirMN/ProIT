using System;

namespace PredicateMethod
{
    class Program
    {
        /// <summary>
        /// Определить совершеннолетний возраст
        /// </summary>
        /// <param name="age">Возраст</param>
        /// <returns>true - совершеннолетний возраст. false - несовершеннолетний возраст</returns>
        static bool IsAdult(byte age)
        {
            const byte ADULTHOOD = 18; // лет
            bool result = age > ADULTHOOD;
            return result;
        }

        static void Main(string[] args)
        {
            byte age = 23;
            bool isAdult = IsAdult(age);

            if (isAdult)
                Console.WriteLine($"В {age} года/лет - кредит доступен.");
            else
                Console.WriteLine($"В {age} года/лет - кредит недоступен.");

            // Delay
            Console.ReadKey();
        }
    }
}
