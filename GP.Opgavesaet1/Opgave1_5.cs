using System;

namespace GP.Opgavesaet1
{
    public class Opgave1_5
    {
        public static void Run()
        {
            Console.WriteLine("Opgave 1.5");
            Console.Write("Indtast l�ngde i cm: ");
            var l�ngde = int.Parse(Console.ReadLine());
            Console.Write("Indtast h�jde i cm: ");
            var h�jde = int.Parse(Console.ReadLine());
            Console.Write("Indtast bredde i cm: ");
            var bredde = int.Parse(Console.ReadLine());

            var rumfangIcm3 = l�ngde*bredde*h�jde;
            var rumfangIdm3 = rumfangIcm3/Math.Pow(10, 3);
            var rumfangIm3 = rumfangIcm3/Math.Pow(100, 3);
            var overfladeIcm2 = (l�ngde*h�jde + l�ngde*bredde + h�jde*bredde)*2;
            var overfladeIm2 = overfladeIcm2/Math.Pow(100, 2);
            Console.WriteLine($"Kassens m�l: l�ngde:{l�ngde}cm, h�jde:{h�jde}cm, bredde:{bredde}cm");
            Console.WriteLine($"Kassend overflade: {overfladeIcm2}cm� = {overfladeIm2}m�");
            Console.WriteLine($"Kassend rumfang: {rumfangIcm3}cm� = {rumfangIdm3}dm� (liter) = {rumfangIm3}m�");
        }
    }
}