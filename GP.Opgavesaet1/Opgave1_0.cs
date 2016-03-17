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
            Console.Write("Indtast fødselsår: ");
            var fødselsår = Console.ReadLine();
            try
            {
                var alder = DateTime.Now.Year - int.Parse(fødselsår);
                Console.WriteLine($"Navn: {navn}, Født: {fødselsår}, Alder: {alder}");
            }
            catch (Exception)
            {
                Console.WriteLine($"'{fødselsår}' er ikke et korrekt indtastet tal!");
            }
        }
    }
}