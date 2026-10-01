using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pw_4
{
    public class Money : Pair, ISummableOfSomePair<Money>
    {
        public Money(int rubles, int kopeks, int number) : base(rubles, kopeks, number) { }

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
    }
}
