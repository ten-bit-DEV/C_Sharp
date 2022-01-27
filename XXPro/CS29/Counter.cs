using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS29
{
    internal class Counter
    {
        private static int _count = 0;

        internal static void Call()
        {
            _count++;
        }

        internal static int GetCount()
        {
            return _count;
        }
    }
}
