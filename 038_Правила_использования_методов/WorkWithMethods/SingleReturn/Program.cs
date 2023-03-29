using System;

namespace SingleReturn
{
    class Program
    {
        static string Translate(string englishWord)
        {
            string russianWord;

            if (englishWord == "mother")
            {
                russianWord = "мать";
            }
            else if (englishWord == "father")
            {
                russianWord = "отец";
            }
            else
            {
                russianWord = "Неизвестное слово!";
            }

            return russianWord;
        }

        static void Main(string[] args)
        {
            string russianWord = Translate("mother");
            Console.WriteLine(russianWord);

            // Delay
            Console.ReadKey();
        }
    }
}
