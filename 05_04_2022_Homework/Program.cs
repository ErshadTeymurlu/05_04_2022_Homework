using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05_04_2022_Homework.Models;

namespace _05_04_2022_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            USD usd = new USD(500);
            AZN azn = new AZN(500);
            EUR eur = new EUR(500);
            Console.WriteLine(azn);
            Console.WriteLine(eur);
            Console.WriteLine(usd);
            Console.WriteLine();
            if (azn > usd) Console.WriteLine($"{azn} is greater than {usd}");
            else Console.WriteLine($"{usd} is greater than {azn}");
            if (azn > eur) Console.WriteLine($"{azn} is greater than {usd}");
            else Console.WriteLine($"{eur} is greater than {azn}");
            if (eur > usd) Console.WriteLine($"{eur} is greater than {usd}");
            else Console.WriteLine($"{usd} is greater than {eur}");

            azn = usd;
            eur = azn;
            usd = new EUR(500);
            Console.WriteLine();
            Console.WriteLine("-----------AFTER EXCHANGE----------");
            Console.WriteLine();
            Console.WriteLine(azn);
            Console.WriteLine(eur);
            Console.WriteLine(usd);
            Console.WriteLine();
            if (azn > usd) Console.WriteLine($"{azn} is greater than {usd}");
            else Console.WriteLine($"{usd} is greater than {azn}");
            if (azn > eur) Console.WriteLine($"{azn} is greater than {usd}");
            else Console.WriteLine($"{eur} is greater than {azn}");
            if (eur > usd) Console.WriteLine($"{eur} is greater than {usd}");
            else Console.WriteLine($"{usd} is greater than {eur}");
            Console.ReadLine();
        }
    }
}
