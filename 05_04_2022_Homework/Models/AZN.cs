using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_04_2022_Homework.Models
{
    internal class AZN
    {
        public readonly double amount;
        public AZN(double amount)
        {
            this.amount = amount;
        }
        public static implicit operator AZN(USD usd)
        {
            return new AZN(usd.amount / 1.7);
        }
        public static implicit operator AZN(EUR eur)
        {
            return new AZN(eur.amount / 1.8);
        }
        public static bool operator >(AZN azn, USD usd)
        {
            return azn.amount / 1.7 > usd.amount;
        }
        public static bool operator > (AZN azn, EUR eur)
        {
            return azn.amount / 1.8 > eur.amount;
        }
        public static bool operator < (AZN azn, EUR eur)
        {
            return azn.amount / 1.8 > eur.amount;
        }
        public static bool operator <(AZN azn, USD usd)
        {
            return azn.amount > usd.amount * 1.7;
        }
        public override string ToString()
        {
            return $"{amount} AZN";
        }
    }
}
