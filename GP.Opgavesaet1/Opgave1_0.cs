using System;

namespace GP.Opgavesaet1
{
    public class Opgave1_0
    {
        public static void Run()
        {
            Console.WriteLine("Opgave 1.0");
            Console.Write("Indtast navn: ");
            var navn = Console.ReadLine();
            Console.Write("Indtast f�dsels�r: ");
            var f�dsels�r = Console.ReadLine();
            try
            {
                var alder = DateTime.Now.Year - int.Parse(f�dsels�r);
                Console.WriteLine($"Navn: {navn}, F�dt: {f�dsels�r}, Alder: {alder}");
            }
            catch (Exception)
            {
                Console.WriteLine($"'{f�dsels�r}' er ikke et korrekt indtastet tal!");
            }
        }
    }
}