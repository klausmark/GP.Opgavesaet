using System;

namespace GP.Opgavesaet1
{
    public class Opgave1_1
    {
        public static void Run()
        {
            Hovedopgaven();
            Ekstraopgaven();
        }

        private static void Hovedopgaven()
        {
            Console.Write("Indtast timer: ");
            var timer = Console.ReadLine();
            Console.Write("Indtast minutter: ");
            var minutter = Console.ReadLine();
            Console.Write("Indtast sekunder: ");
            var sekunder = Console.ReadLine();
            var sumAfSekunder = int.Parse(timer)*60*60 + int.Parse(minutter)*60 + int.Parse(sekunder);
            Console.WriteLine($"{timer} timer {minutter} minutter {sekunder} sekunder er i alt {sumAfSekunder} sekunder");
        }

        private static void Ekstraopgaven()
        {
            Console.Write("Indtast antal sekunder: ");
            var sekunderIAlt = int.Parse(Console.ReadLine());
            var timer = sekunderIAlt/(60*60);
            var minutter = (sekunderIAlt - timer*60*60)/60;
            var sekunder = sekunderIAlt - timer*60*60 - minutter*60;
            Console.WriteLine($"{timer} timer, {minutter} minutter, {sekunder} sekunder");
        }
    }
}