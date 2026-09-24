using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Pw_4
{
    internal class Pair
    {
        public Pair(int x, int y)
        {
            first = x; second = y;
        }
        public int first
        {
            get;
            set;
        }
        public int second
        {
            get;
            set;
        }
        internal int SumOfPair()
        {
            return first+second;
        }
        internal (int, int) SumOfPair(Pair pair_2)
        {
            first += pair_2.first;
            second += pair_2.second;
            return (first, second);
        }
        internal (int, int) SumOfPair(Pair pair_2, Pair pair_3)
        {
            first += pair_2.first + pair_3.first;
            second += pair_2.second + pair_3.second;
            return (first, second);
        }

        internal (int, int) IncrementPostFix(Pair pair)
        {
            return (pair.first++, pair.second++);
        }
    }
}
