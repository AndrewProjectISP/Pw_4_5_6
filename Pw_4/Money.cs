using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Pw_4
{
    public class Money : Pair, ISummableOfSomePair<IPair>
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
        public override int second 
        {
            get => base.second;
            set
            {
                if (value < 0) throw new ArgumentException("Количество копеек не может быть меньше нуля");
                else
                {
                    base.second = value % 100;
                    int countRubles = value / 100;
                    if (countRubles > 0) base.first += countRubles;
                }
            }
        }
        public override (int, int) SumOfPair(IPair money, IPair money2)
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
        public override (int, int) SumOfPair(IPair money, IPair money2, IPair money3)
        {
            int rubles = money.first + money2.first + money3.first;
            int kopeks = (money.second + money2.second + money3.second) % 100;
            int temp = kopeks / 100;
            if (temp > 0) rubles += temp;
            return (rubles, kopeks);
        }
        public static (int, int) DifferenceOfPair(Money money, Money money2)
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
    public class MoneyException : Exception
    {
        public MoneyException(string message) : base(message) { }
    }
}