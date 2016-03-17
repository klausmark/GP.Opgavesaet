using System;

namespace GP.Opgavesaet1
{
    public class Opgave1_3
    {
        public static void Run()
        {
            Console.WriteLine("Opgave 1.3");
            Console.Write("Indtast antal aviser der skal omdeles:");

            var antalAviser = uint.Parse(Console.ReadLine());

            var bundter = antalAviser/50;
            var rest = antalAviser%50;

            Console.WriteLine($"Antal bundter:{bundter}, rest:{rest}");
        }
    }
}