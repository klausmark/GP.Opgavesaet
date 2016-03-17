using System;
using System.Text.RegularExpressions;

namespace GP.Opgavesaet1
{
    public class Opgave1_2
    {
        public static void Run()
        {
            Console.WriteLine("Opgave 1.2");
            Console.Write("Indtast CPR ");
            var cpr = Console.ReadLine();
            var match = Regex.Match(cpr, "^(\\d{2})(\\d{2})(\\d{2})-(\\d{4})$");
            if (!match.Success)
            {
                Console.WriteLine("CPR indtastes com ddmmyy-xxxx");
                return;
            }
            var day = int.Parse(match.Groups[1].Value);
            var month = int.Parse(match.Groups[2].Value);
            var year = int.Parse(match.Groups[3].Value);
            var serial = int.Parse(match.Groups[4].Value);
            year = year > (DateTime.Now.Year - 2000) ? year + 1900 : year + 2000;
            var gender = serial%2 == 0 ? "Kvinde" : "Mand";
            var date = new DateTime(year, month, day);
            Console.WriteLine($"Født:{date:D}, Køn:{gender}");
        }
    }
}