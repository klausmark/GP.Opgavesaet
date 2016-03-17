using System;

namespace GP.Opgavesaet1
{
    public class Opgave1_5
    {
        public static void Run()
        {
            Console.WriteLine("Opgave 1.5");
            Console.Write("Indtast længde i cm: ");
            var længde = int.Parse(Console.ReadLine());
            Console.Write("Indtast højde i cm: ");
            var højde = int.Parse(Console.ReadLine());
            Console.Write("Indtast bredde i cm: ");
            var bredde = int.Parse(Console.ReadLine());

            var rumfangIcm3 = længde*bredde*højde;
            var rumfangIdm3 = rumfangIcm3/Math.Pow(10, 3);
            var rumfangIm3 = rumfangIcm3/Math.Pow(100, 3);
            var overfladeIcm2 = (længde*højde + længde*bredde + højde*bredde)*2;
            var overfladeIm2 = overfladeIcm2/Math.Pow(100, 2);
            Console.WriteLine($"Kassens mål: længde:{længde}cm, højde:{højde}cm, bredde:{bredde}cm");
            Console.WriteLine($"Kassend overflade: {overfladeIcm2}cm² = {overfladeIm2}m²");
            Console.WriteLine($"Kassend rumfang: {rumfangIcm3}cm³ = {rumfangIdm3}dm³ (liter) = {rumfangIm3}m³");
        }
    }
}