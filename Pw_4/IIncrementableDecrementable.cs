using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pw_4
{
    interface IIncrementableDecrementableOfPair<T> : IPair where T: IPair
    {
        public (int, int) IncrementPostFix(T pair);
        public (int, int) IncrementPreFix(T pair);
        public (int, int) DecrementPostFix(T pair);
        public (int, int) DecrementPreFix(T pair);
    }
}
