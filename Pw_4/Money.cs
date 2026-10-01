using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Pw_4
{
    public class Money : Pair, ISummableOfSomePair<Money>
    {
        public Money(int rubles, int kopeks, int number) : base(rubles, kopeks, number) { }
        public override int first 
        {
            get => base.first;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Неккоректно введенные аргументы: баланс не может быть отрицательным");
                base.first = value;
            }
        }
        public override int second { get => base.second; set { if (value < 0 || value >= 100) throw new ArgumentException("Неккоректно введенные аргументы: копейки должны быть в диапазоне от 0 до 99"); } }
        public static (int, int) SumOfPair(Money money, Money money2)
        {
            int rubles = money.first + money2.first;
            int kopeks = money.second + money2.second;
            if (kopeks >= 100)
            {
                rubles += 1;
                kopeks -= 100;
            }
            return (rubles, kopeks);
        }
        public static (int, int) SumOfPair(Money money, Money money2, Money money3)
        {
            int rubles = money.first + money2.first + money3.first;
            int kopeks = money.second + money2.second + money3.second;
            while (kopeks >= 100)
            {
                rubles += 1;
                kopeks -= 100;
            }
            return (rubles, kopeks);
        }
        public static (int, int) DifferenceOfPair(Money money, Money money2)
        {
            if (money.first > money2.first)
            {
                int rubles = money.first - money2.first;
                if (money.second < money2.second)
                {
                    rubles -= 1;
                    money.second += 100;
                }
                int kopeks = money.second - money2.second;
                return (rubles, kopeks);
            }
            else
            {
                throw new ArgumentException("Неккоректно введенные аргументы: баланс не может быть отрицательным");
            }
        }
        public static Money DivideOfPair(Money money, int number)
        {
            money.first /= number;
            money.second /= number;
            return money;
        }
        public override string ToString()
        {
            return $"Money №{Number}";
        }
    }
}