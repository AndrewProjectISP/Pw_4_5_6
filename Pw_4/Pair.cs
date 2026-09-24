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
        internal int SumOfPair(Pair pair)
        {
            return pair.first+pair.second;
        }
        internal (int,int) SumOfPair(Pair pair, Pair pair_2)
        {
            return (pair.first + pair_2.first, pair.second + pair_2.second);
        }
        internal (int, int) SumOfPair(Pair pair, Pair pair_2, Pair pair_3)
        {
            return (pair.first + pair_2.first + pair_3.first, pair.second + pair_2.second + pair_3.second);
        }

        internal (int, int) IncrementPrefix(Pair pair)
        {
            return (pair.first++, pair.second++);
        }
    }
}
