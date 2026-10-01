using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pw_4
{
    public interface ISummableOfSomePair<Tself> where Tself : IPair
    {
        static abstract (int, int) SumOfPair(Tself pair1, Tself pair2);
        static abstract (int, int) SumOfPair(Tself pair, Tself pair2, Tself pair3);
    }
}
