using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection0201
{
    internal class Counter
    {
         public int Value { get; set; }

        public static Counter operator +(Counter a, Counter b)
        {
            return new Counter { Value = a.Value + b.Value };
        }

        public static bool operator &(Counter a, Counter b)
        {
            return  a.Value == b.Value;
        }

        public static Counter operator ++(Counter a)
        {
            return new Counter { Value = a.Value +1 };
        }
    }
}
