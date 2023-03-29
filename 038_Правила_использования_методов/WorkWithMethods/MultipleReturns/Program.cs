using System;

namespace MultipleReturns
{
    class Program
    {
        static string Translate(string englishWord)
        {
            if (englishWord == "mother")
            {
                return "мать";
            }
            else if (englishWord == "father")
            {
                return "отец";
            }

            return "Неизвестное слово!";
        }

        static void Main()
        {
            string russianWord = Translate("mother");
            Console.WriteLine(russianWord);

            // Delay
            Console.ReadKey();
        }
    }
}
