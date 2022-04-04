using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_04_2022_Homework.Models
{
    internal class USD
    {
        public readonly double amount;
        public USD(double amount)
        {
            this.amount = amount;
        }
        public static implicit operator USD(AZN azn)
        {
            return new USD(azn.amount*1.7);
        }
        public static implicit operator USD(EUR eur)
        {
            return new USD(eur.amount / 1.1);
        }
        public static bool operator >(USD usd, AZN azn)
        {
            return usd.amount * 1.7 > azn.amount;
        }
        public static bool operator >(USD usd, EUR eur)
        {
            return usd.amount / 1.1 > eur.amount;
        }
        public static bool operator <(USD usd, EUR eur)
        {
            return usd.amount / 1.1 > eur.amount;
        }
        public static bool operator <(USD usd, AZN azn)
        {
            return usd.amount * 1.7 > azn.amount;
        }
        public override string ToString()
        {
            return $"{amount} USD";
        }
    }
}
