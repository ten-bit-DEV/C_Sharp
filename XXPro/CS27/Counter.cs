using System;
using System.Collections.Generic;
using System.Text;

namespace CS27
{
    class Counter
    {
        private int _count = 0;
        private string unit = "回";

        public Counter(int count)
        {
            SetCount(count);
        }

        //public int Count {
        //    get { return _count; }
        //    set
        //    {
        //        if (value >= 100)
        //        {
        //            _count = 100;
        //            return;
        //        }
        //        _count = value;
        //    }
        //}
        public int Count { get; private set; }

        public void Call()
        {
            _count++;
        }

        public void SetCount(int value)
        {
            if (value >= 100)
            {
                _count = 100;
                return;
            }
            _count = value;
        }

        public int GetCount()
        {
            return _count;
        }
    }
}
