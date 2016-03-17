using System;

namespace GP.Opgavesaet1
{
    public class Opgave1_4
    {
        public static void Run()
        {
            Console.WriteLine("Opgave 1.4");
            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.WriteLine($"Output: {input.Length} (antal tegn)");
            Console.WriteLine($"Output: {input.Replace('e', 'ø')} (e erstattet med ø)");
            Console.WriteLine($"Output: {input.ToUpper()} (alle bogstaver store)");
            var førsteTegnStort = input.ToLower();
            førsteTegnStort = førsteTegnStort.Substring(0, 1).ToUpper() + førsteTegnStort.Substring(1);
            Console.WriteLine($"Output: {førsteTegnStort} (første tegn stort)");
        }
    }
}