using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_04_2022_Homework.Models
{
    internal class EUR
    {
        public readonly double amount;
        public EUR(double amount)
        {
            this.amount = amount;
        }
        public static implicit operator EUR(AZN azn)
        {
            return new EUR(azn.amount * 1.8);
        }
        public static implicit operator EUR(USD usd)
        {
            return new EUR(usd.amount * 1.1);
        }
        public static bool operator >(EUR eur, AZN azn)
        {
            return eur.amount * 1.8 > azn.amount;
        }
        public static bool operator >(EUR eur, USD usd)
        {
            return eur.amount * 1.1 > usd.amount;
        }
        public static bool operator <(EUR eur, USD usd)
        {
            return eur.amount * 1.1 > usd.amount;
        }
        public static bool operator <(EUR eur, AZN azn)
        {
            return eur.amount * 1.8 > azn.amount;
        }
        public override string ToString()
        {
            return $"{amount} EUR";
        }
    }
}
