using System;

namespace IntegerExclusiveOr
{
    class Program
    {
        static void Main(string[] args)
        {
            char originalValue = 'A';
            Console.WriteLine($"originalValue = {originalValue}");

            ushort key = 55;
            Console.WriteLine($"key = {key}");

            char encryptedValue = (char)(originalValue ^ key);
            Console.WriteLine($"encryptedValue = {encryptedValue}");

            char decryptedValue = (char)(encryptedValue ^ key);
            Console.WriteLine($"decryptedValue = {decryptedValue}");

            // Delay
            Console.ReadKey();
        }
    }
}
