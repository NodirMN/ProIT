using System;

namespace EscapeSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine('\''); // Single quotation mark
            //Console.WriteLine("\'");
            //Console.WriteLine("'");

            //Console.WriteLine("Вася сказал: \"Привет\"."); // Double quotation mark
            //Console.WriteLine(@"Вася сказал: ""Привет"".");

            //Console.WriteLine("C:\\Windows\\notepad.exe"); // Путь к блокноту
            //Console.WriteLine(@"C:\Windows\notepad.exe");

            //Console.WriteLine("Hello world!\0"); // Нуль-терминированная строка

            //Console.WriteLine("\a");           // Alert (Звук-предупреждение)

            //Console.Write("Backspace\b");      // Возврат на одну позицию
            //Console.WriteLine("!");

            //Console.WriteLine("Привет \f Пока"); // Переход на новую страницу *для принтера

            //Console.Write("Hello\n");          // Переход на новую строку

            //Console.Write("Hello\r");          // Возврат (каретки) курсора в начало строки 

            //Console.WriteLine("1 \t 2 \t 3");  // Горизонтальная табуляция

            //Console.WriteLine("1 \v 2 \v 3");  // Вертикальная табуляция *для принтера



            // Коды ASCII символов в шестнадцатеричном формате
            //                   H   e   l   l  o        w   o   r   l   d   !
            //Console.WriteLine("\x48\x65\x6c\x6c\x6f\x20\x57\x6f\x72\x6c\x64\x21");

            // Коды Unicode символов в шестнадцатеричном формате
            //                   H      e     l     l     o           w     o     r     l     d     !
            //Console.WriteLine("\x0048\x0065\x006c\x006c\x006f\x0020\x0057\x006f\x0072\x006c\x0064\x0021");

            // Коды Unicode символов в шестнадцатеричном формате
            //                   H      e     l     l     o           w     o     r     l     d     !
            //Console.WriteLine("\u0048\u0065\u006c\u006c\u006f\u0020\u0057\u006f\u0072\u006c\u0064\u0021");



            // Коды ASCII символов в шестнадцатеричном формате
            Console.WriteLine('\x48' + '\x65' + '\x6c' + '\x6c' + '\x6f' + '\x20' +
                              '\x57' + '\x6f' + '\x72' + '\x6c' + '\x64' + '\x21');

            // Коды Unicode символов в шестнадцатеричном формате
            Console.WriteLine('\u0048' + '\u0065' + '\u006c' + '\u006c' + '\u006f' + '\u0020' +
                              '\u0057' + '\u006f' + '\u0072' + '\u006c' + '\u0064' + '\u0021');

            // Коды Unicode символов в шестнадцатеричном формате
            Console.WriteLine('\u0048' + '\u0065' + '\u006c' + '\u006c' + '\u006f' + '\u0020' +
                              '\u0057' + '\u006f' + '\u0072' + '\u006c' + '\u0064' + '\u0021');


            // Delay
            Console.ReadKey();
        }
    }
}
